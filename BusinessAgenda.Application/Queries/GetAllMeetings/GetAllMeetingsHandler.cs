using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Application.Command;
using BusinessAgenda.Application.Command.Models;
using BusinessAgenda.Core.Repositories;
using MediatR;

namespace BusinessAgenda.Application.Queries.GetAllMeetings
{
    public class GetAllMeetingsHandler : IRequestHandler<GetAllMeeetingsQuery, ResultViewModel<List<MeetingViewModel>>>
    {
        private readonly IMeetingRepository _repository;
        public GetAllMeetingsHandler(IMeetingRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<List<MeetingViewModel>>> Handle(GetAllMeeetingsQuery request, CancellationToken cancellationToken)
        {
            var meetings = await _repository.GetAll();
            var model = meetings.Select(MeetingViewModel.FromEntity).ToList();
            return ResultViewModel<List<MeetingViewModel>>.Success(model);
        }
    }
}
