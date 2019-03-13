using Application.Dto;
using AutoMapper;
using Domain.Entities;


namespace Application.Mappings.DomainToDtoMapping
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {   
            CreateMap<COUNTRy, CountryDto>();
        }
    }
}
