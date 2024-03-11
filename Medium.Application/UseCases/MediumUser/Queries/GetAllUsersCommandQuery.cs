using MediatR;
using Medium.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.UseCases.MediumUser.Queries
{
    public class GetAllUsersCommandQuery : IRequest<List<User>>
    {

    }
}
