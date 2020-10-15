using AutoMapper;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Mappers
{
    public class ContainerMappings : Profile
    {
        public ContainerMappings()
        {
            CreateMap<Container, ContainerDto>().ReverseMap();
        }
    }
}
