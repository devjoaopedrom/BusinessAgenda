using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Application.Command;
using BusinessAgenda.Application.Command.Models;
using MediatR;

namespace BusinessAgenda.Application.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<ResultViewModel<UserViewModel>>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
        public int Id
        {
            get; private set;

        }
    }
}
