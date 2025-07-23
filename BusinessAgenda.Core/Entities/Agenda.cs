using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAgenda.Core.Entites
{
    public class Agenda : BaseEntity
    {

        public Agenda(User user, int userId, DateTime data, ICollection<Meeting> meetings, int year )
        {
            User = user;
            UserId = userId;
            Meetings = meetings;
            Year = year;  
        }

        public User User { get; set; }
        public int UserId { get; set; }
        public int Year { get; set; } // define o ano da agenda, ex: 2025
        public ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();
    }
}   
