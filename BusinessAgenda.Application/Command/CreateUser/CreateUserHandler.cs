using BusinessAgenda.Core.Repositories;
using MediatR;

namespace BusinessAgenda.Application.Command.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, ResultViewModel<int>>
    {
        private readonly IUserRepository _repository;
        private readonly IMediator _mediator;
        public CreateUserHandler(IUserRepository repository, IMediator mediator)
        {
            _mediator = mediator;
            _repository = repository;
        }
        public async Task<ResultViewModel<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.ToEntity();

            await _repository.AddUser(user);

            return ResultViewModel<int>.Success(user.Id);
        }
    }
}
