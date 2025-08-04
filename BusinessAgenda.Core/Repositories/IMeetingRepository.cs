using BusinessAgenda.Core.Entities;

namespace BusinessAgenda.Core.Repositories
{
    public interface IMeetingRepository
    {

            Task<List<Meeting>> GetAll();
            Task<Meeting?> GetDetailsById(int id);
            Task<Meeting> GetById(int id);
            Task<int> Add(Meeting meeting);
            Task Update(Meeting meeting);
            Task AddComment();
            Task<bool> Exists(int id);
            Task<bool> HasScheduleConflictAsync(int managerId, DateTime start, DateTime end, CancellationToken cancellationToken);
    }

}

    