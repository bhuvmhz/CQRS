using MediatR;
using Models;
using System.Collections.Generic;

namespace Scenarios.CarScenarios
{
    public class GetCarsRequest : IRequest<IEnumerable<Car>>
    {
        public string PlateNo { get; set; }
    }
}
