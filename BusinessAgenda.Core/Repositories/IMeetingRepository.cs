using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entites;

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
    }

}

    