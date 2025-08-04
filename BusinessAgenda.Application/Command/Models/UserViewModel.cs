using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entities;

namespace BusinessAgenda.Application.Command.Models
{
    public class UserViewModel
    {
        public UserViewModel(int id,string fullName, string email, List<UserSkill> skills)
    : base()
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Skills = skills;
            
        } 
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public List<UserSkill> Skills { get; private set; }

        public static UserViewModel FromEntity(User user)
                => new(
                user.Id,
                user.FullName,
                user.Email,
                user.Skills.ToList()
            );
    }
}
