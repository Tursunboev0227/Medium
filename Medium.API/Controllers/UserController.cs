using MediatR;
using Medium.Application.UseCases.MediumUser.Commands;
using Medium.Application.UseCases.MediumUser.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medium.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController(IMediator _mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            await _mediator.Send(command);

            return Ok("Created");
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
           var result= await _mediator.Send(new GetAllUsersCommandQuery());

            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetByIdUser(Guid Id)
        {
            var result = await _mediator.Send(new GetByIdUserCommandQuery() { Id=Id});

            return Ok(result);
        }
    }
}
