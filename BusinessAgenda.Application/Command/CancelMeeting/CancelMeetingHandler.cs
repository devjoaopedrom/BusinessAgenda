using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Application.Command.CanceledMeeting;
using BusinessAgenda.Core.Repositories;
using MediatR;

namespace BusinessAgenda.Application.Command.CancelMeeting
{
    public class CancelMeetingHandler : IRequestHandler<CancelMeetingCommand, ResultViewModel>
    {
        private readonly IMeetingRepository _repository;
        public CancelMeetingHandler(IMeetingRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(CancelMeetingCommand request, CancellationToken cancellationToken)
        {
            var meeting = await _repository.GetById(request.Id);

            if (meeting is null )
            {
                return ResultViewModel.Error("This meeting isn't exists");
            }

            meeting.Cancel();
            await _repository.Update(meeting);

            return ResultViewModel.Success();
        }
    }
}
