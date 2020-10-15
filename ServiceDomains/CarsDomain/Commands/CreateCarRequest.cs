using MediatR;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsScenarios.CarsDomain.Commands
{
    public class CreateCarHandler : IRequest<Car>
    {
        public string PlateNo { get; set; }
        public string Model { get; set; }
    }
}
