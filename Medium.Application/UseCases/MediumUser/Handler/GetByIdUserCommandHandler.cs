using MediatR;
using Medium.Domain.Entities;
using Medium.Application.UseCases.MediumUser.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Medium.Application.Absatractions;
using Microsoft.EntityFrameworkCore;

namespace Medium.Application.UseCases.MediumUser.Handler
{
    public class GetByIdUserCommandHandler : IRequestHandler<GetByIdUserCommandQuery, User>
    {
        private readonly IApplicationDbContext _dbContext;
        public GetByIdUserCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Handle(GetByIdUserCommandQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x=> x.Id == request.Id && x.IsDeleted!=true);
            return user;
        }
    }
}
