using MediatR;
using Medium.Application.Absatractions;
using Medium.Application.UseCases.MediumUser.Queries;
using Medium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.UseCases.MediumUser.Handler
{
    public class GetAllUserCommandQueryHandler : IRequestHandler<GetAllUsersCommandQuery, List<User>>
    {
       // private readonly IMediator mediator;
        private readonly IApplicationDbContext _applicationDbContext;
        public GetAllUserCommandQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext= applicationDbContext;
        }
        public async Task<List<User>> Handle(GetAllUsersCommandQuery request, CancellationToken cancellationToken)
        {
            var users = await _applicationDbContext.Users.ToListAsync();
            return users;
        }
    }
}
