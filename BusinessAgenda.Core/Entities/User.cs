using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entites.Enums;

namespace BusinessAgenda.Core.Entites
{
    public class User : BaseEntity
    {
            public User(string fullName, string email, DateTime birthDate, Agenda agenda)
                : base()
            {
                FullName = fullName;
                Email = email;
                BirthDate = birthDate;
                Active = true;
                Agenda = agenda;

                Skills = [];
                ManagerMeetings = [];
                Comments = [];
                

            }

            public string FullName { get; private set; }
            public string Email { get; private set; }
            public DateTime BirthDate { get; private set; }
            public bool Active { get; private set; }
            public List<UserSkill> Skills { get; private set; }
            public List<Meeting> ManagerMeetings { get; private set; }
            public List<MeetingComments> Comments { get; private set; }
            public Agenda Agenda { get; private set; }

    }

}
