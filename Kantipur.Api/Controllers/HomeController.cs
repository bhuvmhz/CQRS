using MediatR;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Scenarios.CarScenarios;
using Documents.CarDocuments;

namespace Kantipur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetCars([FromQuery] GetCarsRequest query)
        {
            return await _mediator.Send(query).ConfigureAwait(false);
        }

        [HttpPost]
        public async Task<Car> CreateCar([FromBody] CreateCarHandler command)
        {
            return await _mediator.Send(command).ConfigureAwait(false);
        }
    }
}
