﻿using MediatR;
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
        [HttpGet("{id}/{date}")]
        public async Task<IActionResult> GetActivitiesByDate(int id, int date)
        {
            var query = new GetAtividadeByDateQuery(id, date);
            var activities = await _mediator.Send(query);
            if (activities == null) return NotFound();

            return Ok(activities);
        }
        [HttpPost]
        public async Task<IActionResult> AddActivitie([FromBody] AddActivitieCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetActivitiesByDate), new {id = id}, command);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateActivitie([FromBody] UpdateAtividadeCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
