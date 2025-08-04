using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entities;
using BusinessAgenda.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BusinessAgenda.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BusinessAgendaDbContext _context;
        public UserRepository(BusinessAgendaDbContext context)
        {
            _context = context;
        }
        public Task<List<UserSkill>> AddSkill(List<UserSkill> userSkills)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.Users
            // Inclua apenas relacionamentos reais
            .Include(u => u.Agenda)
            .Include(u => u.Skills)
            .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
