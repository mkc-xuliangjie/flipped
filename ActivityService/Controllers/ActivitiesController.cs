using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ActivityService.Application.Activities;
using ActivityService.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ActivityService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : Controller
    {
        private readonly IMediator mediator;

        public ActivitiesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Activity>> List()
        {
            return await mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<Activity> Details(Guid id)
        {
            return await mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<Unit> Create(Create.Command command)
        {
            return await mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<Unit> Edit(Guid id, Edit.Command command)
        {
            command.Id = id;
            return await mediator.Send(command);
        }

        [HttpDelete("{id}")]
        public async Task<Unit> Delete(Guid id)
        {
            return await mediator.Send(new Delete.Command { Id = id });
        }
    }
}