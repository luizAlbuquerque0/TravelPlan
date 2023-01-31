using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelPlan.Application.Queries.GetAtividadeByDate;

namespace TravelPlan.API.Controllers
{
    [Route("api/activities")]
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
    }
}
