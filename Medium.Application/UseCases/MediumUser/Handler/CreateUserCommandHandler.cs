using AutoMapper;
using MediatR;
using Medium.Application.Absatractions;
using Medium.Application.UseCases.MediumUser.Commands;
using Medium.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.UseCases.MediumUser.Handler
{
    public class CreateUserCommandHandler : AsyncRequestHandler<CreateUserCommand>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        protected async override Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            await _applicationDbContext.Users.AddAsync(user); 
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
