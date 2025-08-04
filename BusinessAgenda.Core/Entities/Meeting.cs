using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entites.Enums;

namespace BusinessAgenda.Core.Entities
{
        public class Meeting : BaseEntity
        {
            public DateTime StartTime { get; private set; }
            public DateTime EndTime { get; private set; }
            public int ClientId { get; private set; }
            public Client Client { get; private set; }
            public string Address { get; private set; }
            public int ManagerId { get; private set; }
            public User Manager { get; private set; }
            public List<MeetingComment>Comments { get; private set; }

            public MeetingStatusEnum Status { get; private set; }

        public Meeting(DateTime startTime, int clientId, string address, int managerId)
            : base()
        {
                StartTime = startTime;
                EndTime = startTime.AddHours(1);
                ClientId = clientId;
                Address = address;
                ManagerId = managerId;

         }


        // Método para cancelar
        public void Cancel()
        {
            Status = MeetingStatusEnum.Cancelled;
        }

        // Método para disponibilizar
        public void SetAvailable()
        {
            Status = MeetingStatusEnum.Available;
        }

        // Método para ocupar
        public void SetOccupied()
        {
            Status = MeetingStatusEnum.Occupied;
        }

    }

}
