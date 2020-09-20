using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Models;

namespace CarsScenarios.CarsDomain.Commands
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
