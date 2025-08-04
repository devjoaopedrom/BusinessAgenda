using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Application.Command;
using BusinessAgenda.Application.Command.DeleteUser;
using BusinessAgenda.Core.Entites;
using BusinessAgenda.Core.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BusinessAgenda.Application.Command.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, ResultViewModel>
    {
        private readonly IUserRepository _repository;
        public DeleteUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetById(request.Id);

            if (user is null)
            {
                return ResultViewModel.Error("Este Usuario não existe.");
            }

            user.SetAsDeleted();
            await _repository.UpdateUser(user);
            return ResultViewModel.Success();
        }
    }
}
