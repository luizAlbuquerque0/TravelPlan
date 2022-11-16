using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelPlan.Application.Commands.CreateUser;
using TravelPlan.Application.Commands.LoginUser;

namespace TravelPlan.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(Login), new { id = id }, command);
        }

        [HttpPut("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
        {
            var loginUserViewModel = await _mediator.Send(command);
            if (loginUserViewModel == null) return BadRequest();

            return Ok(loginUserViewModel);
        }
    }
}
