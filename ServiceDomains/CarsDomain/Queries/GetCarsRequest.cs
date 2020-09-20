using System.Collections.Generic;
using MediatR;
using Models;

namespace CarsScenarios.CarsDomain.Queries
{
    public class GetCarsRequest : IRequest<IEnumerable<Car>>
    {
        public string PlateNo { get; set; }
    }
}
