using AutoMapper;
using FluentValidation.Results;
using TCE.CrossCutting.Dto;

namespace Dto.Mappings
{
    public class ToDtoMappingProfile : Profile
    {
        public ToDtoMappingProfile()
        {
            CreateMap<ValidationFailure, ValidationFailureDto>();
            CreateMap<ValidationResult, ValidationResultDto>().ForMember(e => e.Errors, opt => opt.MapFrom(src => src.Errors));

        }
    }
}
