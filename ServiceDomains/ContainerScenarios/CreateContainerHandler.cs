using AutoMapper;
using Documents.ContainerDocuments;
using Kantipur.Persistence.Repositories.IRepository;
using MediatR;
using Models;
using Models.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace Scenarios.ContainerScenarios
{
    public class CreateContainerCommandHandler : IRequestHandler<CreateContainerHandler, ContainerDto>
    {
        public IContainerRepository _containerRepo { get; set; }
        public IMapper _mapper { get; set; }

        public CreateContainerCommandHandler(IContainerRepository containerRepo, IMapper mapper)
        {
            _containerRepo = containerRepo;
            _mapper = mapper;
        }

        public async Task<ContainerDto> Handle(CreateContainerHandler request, CancellationToken cancellationToken)
        {
            var container = _mapper.Map<Container>(request);
            _containerRepo.CreateContainer(container);

            await Task.Delay(500, cancellationToken).ConfigureAwait(false);
            return new ContainerDto();
        }
    }
}
