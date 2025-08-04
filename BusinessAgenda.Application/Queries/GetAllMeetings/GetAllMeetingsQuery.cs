using BusinessAgenda.Application.Command;
using BusinessAgenda.Application.Command.Models;
using BusinessAgenda.Core.Repositories;
using MediatR;

namespace BusinessAgenda.Application.Queries.GetAllMeetings
{
    public class GetAllMeeetingsQuery : IRequest<ResultViewModel<List<MeetingViewModel>>>
    {
        private readonly IMeetingRepository _repository;

    }
}   

