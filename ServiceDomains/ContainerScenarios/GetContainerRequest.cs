using MediatR;
using Models.Dtos;
using System.Collections.Generic;

namespace Scenarios.ContainerScenarios
{
    public class GetContainerRequest : IRequest<ContainerDto>, IBaseRequest
    {
        public int ContainerId { get; set; }
    }
}
