using AutoMapper;
using Documents.ContainerDocuments;
using Models.Dtos;

namespace Mappers.Containers
{
    public class ContainerMappings : Profile
    {
        public ContainerMappings()
        {
            CreateMap<Container, ContainerDto>().ReverseMap();
        }
    }
}
