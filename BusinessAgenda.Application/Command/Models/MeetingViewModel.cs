using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entities;

namespace BusinessAgenda.Application.Command.Models
{
    public class MeetingViewModel
    {
        public MeetingViewModel(int id, DateTime startTime, string address, string clientName, string managerName, string status)
        {
            Id = id;
            StartTime = startTime;
            Address = address;
            ClientName = clientName;
            ManagerName = managerName;
            Status = status;
        }
        public int Id { get; private set; }
        public DateTime StartTime { get; private set; }
        public string Address { get; private set; }
        public string ClientName { get; private set; }
        public string ManagerName { get; private set; }
        public string Status { get; private set; }

        public static MeetingViewModel FromEntity(Meeting entity)
                => new(
                entity.Id,
                entity.StartTime,
                entity.Address,
                entity.Client.FullName,
                entity.Manager.FullName,
                entity.Status.ToString()
            );
    }
}      