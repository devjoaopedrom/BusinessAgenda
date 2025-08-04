using BusinessAgenda.Core.Entities;
using BusinessAgenda.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BusinessAgenda.Infrastructure.Persistence.Repositories
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly BusinessAgendaDbContext _context;

        public MeetingRepository(BusinessAgendaDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Meeting meeting)
        {
            await _context.AddAsync(meeting);
            await _context.SaveChangesAsync();

            return meeting.Id;  
        }

        public Task AddComment()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Meeting>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Meeting> GetById(int id)
        {
            return await _context.Meetings
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public Task<Meeting?> GetDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HasScheduleConflictAsync(int managerId, DateTime start, DateTime end, CancellationToken cancellationToken)
        {
            return await _context.Meetings.AnyAsync(m =>
                m.ManagerId == managerId &&
                 m.Status == Core.Entites.Enums.MeetingStatusEnum.Occupied &&
                 m.StartTime < end &&
                 m.EndTime > start,
                 cancellationToken);
        }

        public async Task Update(Meeting meeting)
        {
            _context.Meetings.Update(meeting);
            await _context.SaveChangesAsync();
        }
    }
}
