using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelPlan.Application.Commands.AddActivitie;
using TravelPlan.Application.Commands.UpdateAtividade;
using TravelPlan.Application.Queries.GetAtividadeByDate;

namespace TravelPlan.API.Controllers
{
    [Route("api/activities")]
    [Authorize]
    public class ActivitiesControllers : ControllerBase
    {
        private readonly IMediator _mediator;
        public ActivitiesControllers(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetActivitiesByDate([FromBody] GetAtividadeByDateQuery query)
        {
            var activities = await _mediator.Send(query);
            if (activities == null) return NotFound();

            return Ok(activities);
        }
        [HttpPost]
        public async Task<IActionResult> AddActivitie([FromBody] AddActivitieCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateActivitie([FromBody] UpdateAtividadeCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
