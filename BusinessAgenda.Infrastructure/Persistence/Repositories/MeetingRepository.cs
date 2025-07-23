using BusinessAgenda.Core.Entites;
using BusinessAgenda.Core.Repositories;

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

        public Task<Meeting> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Meeting?> GetDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Meeting meeting)
        {
            throw new NotImplementedException();
        }
    }
}
