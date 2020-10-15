using AutoMapper;
using Kantipur.Persistence.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Dtos;
using System.Collections.Generic;

namespace Kantipur.Api.Controllers.Containers
{
    [Route("api/Container")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly IContainerRepository _containerRepo;
        private readonly IMapper _mapper;

        public ContainerController(IContainerRepository containerRepo, IMapper mapper)
        {
            _containerRepo = containerRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetContainers()
        {
            var containers = _containerRepo.GetContainers();
            var containersDto = new List<ContainerDto>();

            foreach (var c in containers)
            {
                containersDto.Add(_mapper.Map<ContainerDto>(c));
            }
            return Ok(containersDto);
        }

        [HttpGet("{containerId:int}", Name = "GetContainer")]
        public IActionResult GetContainer(int containerId)
        {
            var container = _containerRepo.GetContainer(containerId);
            if (container == null)
            {
                return NotFound();
            }

            var containerDto = _mapper.Map<ContainerDto>(container);
            return Ok(containerDto);
        }

        [HttpPost]
        public IActionResult CreateContainer([FromBody] ContainerDto containerDto)
        {
            if (containerDto == null)
            {
                return BadRequest(ModelState);
            }

            var container = _mapper.Map<Container>(containerDto);
            if (!_containerRepo.CreateContainer(container))
            {
                ModelState.AddModelError("", $"Something went wrong when saving the record {container.ContainerId} : {container.ContainerName}");
                return StatusCode(500, ModelState);
            }
            return CreatedAtRoute("GetContainer", new { containerId = container.ContainerId }, container);
        }
    }
}
