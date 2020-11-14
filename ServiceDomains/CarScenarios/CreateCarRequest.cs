using Documents.CarDocuments;
using MediatR;
using Models;

namespace Scenarios.CarScenarios
{
    public class CreateCarHandler : IRequest<Car>
    {
        public string PlateNo { get; set; }
        public string Model { get; set; }
    }
}
