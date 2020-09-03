using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceDomains.CarsDomain.Commands
{
    public class CreateCarCommand : IRequest<string> { }

    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, string>
    {
        public CreateCarCommandHandler()
        {

        }

        public Task<string> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
