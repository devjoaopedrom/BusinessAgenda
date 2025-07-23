using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using BusinessAgenda.Core.Repositories;

namespace BusinessAgenda.Application.Comnmand.CreatedEvent
{
    internal class CreatedMeetingHandler : IRequestHandler<CreatedMeetingCommand, ResultViewModel<int>>
    {
        private readonly IMediator _mediator;
        private readonly IMeetingRepository _repository;
        public CreatedMeetingHandler(IMediator mediator, IMeetingRepository repository)
        {
            _mediator = mediator;
            _repository = repository;
        }
        public async Task<ResultViewModel<int>> Handle(CreatedMeetingCommand request, CancellationToken cancellationToken)
        {

            var meeting = request.ToEntity();

            await _repository.Add(meeting);

            return ResultViewModel<int>.Success(meeting.Id);
        }
    }
}
