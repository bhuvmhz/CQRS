using MediatR;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos;
using Scenarios.ContainerScenarios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kantipur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContainerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ContainerDto> GetContainer([FromQuery] GetContainerRequest query)
        {
            return await _mediator.Send(query).ConfigureAwait(false);
        }

        [HttpPost]
        public async Task<ContainerDto> CreateContainer([FromBody] CreateContainerHandler command)
        {
            return await _mediator.Send(command).ConfigureAwait(false);
        }
    }
}
