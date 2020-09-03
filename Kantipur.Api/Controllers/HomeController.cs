using MediatR;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceDomains.CarsDomain.Commands;
using ServiceDomains.CarsDomain.Queries;

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
        public async Task<IEnumerable<Car>> GetAllCars([FromRoute] GetAllCarsQuery query)
        {
            return await _mediator.Send(query).ConfigureAwait(false);
        }

        [HttpPost]
        public async Task<string> CreateCar([FromBody] CreateCarCommand command)
        {
            return await _mediator.Send(command).ConfigureAwait(false);
        }
    }
}
