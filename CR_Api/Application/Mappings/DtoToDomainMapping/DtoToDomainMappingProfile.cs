using Application.Dto;
using AutoMapper;
using Domain.Entities;

using System;

namespace Application.Mappings.DomainToDtoMapping
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<CountryDto, COUNTRy>();
        }

    }
}
