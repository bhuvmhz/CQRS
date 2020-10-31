using MediatR;
using Models;
using System.Threading;
using System.Threading.Tasks;

namespace Scenarios.CarScenarios
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarHandler, Car>
    {
        public CreateCarCommandHandler()
        {

        }

        public async Task<Car> Handle(CreateCarHandler request, CancellationToken cancellationToken)
        {
            await Task.Delay(500, cancellationToken).ConfigureAwait(false);
            return new Car();
        }
    }
}
