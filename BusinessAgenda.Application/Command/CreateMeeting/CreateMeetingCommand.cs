using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Application.Command;
using BusinessAgenda.Core.Entities;
using MediatR;

namespace BusinessAgenda.Application.Comnmand.CreatedEvent
{
    public class CreateMeetingCommand : IRequest<ResultViewModel<int>>
    {
        public DateTime StartTime { get; set; }
        public string Address { get; set; }
        public int ClientId { get;  set; }
        
        public int ManagerId { get;  set; }



        public Meeting ToEntity()
            => new(StartTime, ClientId, Address , ManagerId);

    }
}
