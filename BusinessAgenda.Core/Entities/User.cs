using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entites.Enums;
using BusinessAgenda.Core.Entities;

namespace BusinessAgenda.Core.Entities
{
    public class User : BaseEntity
    {
            public User(string fullName, string email, DateTime birthDate)
                : base()
            {
                FullName = fullName;
                Email = email;
                BirthDate = birthDate;

                Skills = [];
                ManagerMeetings = [];
                Comments = [];
            }

            public string FullName { get; private set; }
            public string Email { get; private set; }
            public DateTime BirthDate { get; private set; }
            public List<UserSkill> Skills { get; private set; }
            public List<Meeting>? ManagerMeetings { get; private set; }
            public List<MeetingComment>? Comments { get; private set; }
            public Agenda Agenda { get; private set; }
    }

}
