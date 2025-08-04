using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using BusinessAgenda.Core.Repositories;
using BusinessAgenda.Application.Comnmand.CreatedEvent;

namespace BusinessAgenda.Application.Command.CreatedEvent
{
    internal class CreateMeetingHandler : IRequestHandler<CreateMeetingCommand, ResultViewModel<int>>
    {
        private readonly IMediator _mediator;
        private readonly IMeetingRepository _repository;
        public CreateMeetingHandler(IMediator mediator, IMeetingRepository repository)
        {
            _mediator = mediator;
            _repository = repository;
        }
        public async Task<ResultViewModel<int>> Handle(CreateMeetingCommand request, CancellationToken cancellationToken)
        {
            var startTime = request.StartTime;
            var endTime = request.StartTime.AddHours(1);

            var conflict = await _repository.HasScheduleConflictAsync(request.ManagerId, startTime, endTime, cancellationToken);
            if (conflict)
                return ResultViewModel<int>.Error("There is already a meeting scheduled for that time slot.");

            
            var meeting = request.ToEntity();


            await _repository.Add(meeting);

            return ResultViewModel<int>.Success(meeting.Id);
        }
    }
}
