using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelPlan.Application.Commands.AddDayBudget;
using TravelPlan.Application.Commands.AddSavedMoney;
using TravelPlan.Application.Commands.CreateViagem;
using TravelPlan.Application.Commands.Withdrawn;
using TravelPlan.Application.Queries.GetUserViagens;
using TravelPlan.Application.Queries.GetViagemById;

namespace TravelPlan.API.Controllers
{
    [Route("api/travels")]
    public class TravelsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TravelsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetViagemByIdQuery(id);

            var viajem = await _mediator.Send(query);
            if(viajem == null) return NotFound();

            return Ok(viajem);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTravel([FromBody] CreateViagemCommand command)
        {
            var travel = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { travel = travel }, command);
        }

        [HttpGet("users/{id}")]
        public async Task<IActionResult> GetAllUserTravelsById(int id)
        {
            var query = new GetUserViagensQuery(id);

            var travels = await _mediator.Send(query);
            if (travels == null) return NotFound();

            return Ok(travels);
        }

        [HttpPost("budget")]
        public async Task<IActionResult> AddDayBudget([FromBody] AddDayBudgetCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }
        [HttpPost("save")]
        public async Task<IActionResult> AddSavedMoney([FromBody] AddSavedMoneyCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }
        [HttpPost("withdrawn")]
        public async Task<IActionResult> WithDrawnMoney([FromBody] WithdrawnCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }
    }
}
