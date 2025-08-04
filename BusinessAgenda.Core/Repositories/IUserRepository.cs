using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entities;

namespace BusinessAgenda.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetById(int id);
        Task<int> AddUser(User user);
        Task<List<UserSkill>> AddSkill(List<UserSkill> userSkills);
        Task<bool> Exists(int id);
        Task UpdateUser(User user);
    }
}
