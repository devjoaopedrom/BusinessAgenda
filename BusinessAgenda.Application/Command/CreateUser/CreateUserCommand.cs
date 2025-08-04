using BusinessAgenda.Core.Entities;
using MediatR;

namespace BusinessAgenda.Application.Command.CreateUser
{
    public class CreateUserCommand : IRequest<ResultViewModel<int>>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public User ToEntity()
             => new(FullName, Email, BirthDate);
    }
}
