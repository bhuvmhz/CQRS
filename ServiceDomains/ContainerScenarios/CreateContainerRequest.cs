using MediatR;
using Models.Dtos;

namespace Scenarios.ContainerScenarios
{
    public class CreateContainerHandler : IRequest<ContainerDto>
    {
        public int ContainerId { get; set; }
    }
}
