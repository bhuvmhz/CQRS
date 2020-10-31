using AutoMapper;
using Kantipur.Persistence.Repositories.IRepository;
using MediatR;
using Models.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace Scenarios.ContainerScenarios
{
    public class GetContainerHandler : IRequestHandler<GetContainerRequest, ContainerDto>
    {
        public IContainerRepository _containerRepo { get; set; }
        public IMapper _mapper { get; set; }

        public GetContainerHandler(IContainerRepository containerRepo, IMapper mapper)
        {
            _containerRepo = containerRepo;
            _mapper = mapper;
        }

        public async Task<ContainerDto> Handle(GetContainerRequest request, CancellationToken cancellationToken)
        {
            var container = _containerRepo.GetContainer(request.ContainerId);
            if (container == null)
            {
                return null;
            }

            await Task.Delay(500, cancellationToken).ConfigureAwait(false);

            var containerDto = _mapper.Map<ContainerDto>(container);
            return containerDto;
        }
    }
}
