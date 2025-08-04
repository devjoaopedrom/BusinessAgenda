using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BusinessAgenda.Application.Command.CanceledMeeting
{
    public class CancelMeetingCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }

        public CancelMeetingCommand( int id)
        {
            Id = id;
        }

    }
}
