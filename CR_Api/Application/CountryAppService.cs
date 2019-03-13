using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using TCE.CrossCutting.Dto;

namespace Application
{
    public class CountryAppService : AppServiceBaseLocal<COUNTRy, CountryDto>, ICountryAppService
    {
        private readonly ICountryService _service;

        public CountryAppService(ICountryService service) : base(service)
        {
            _service = service;
        }
        

        public override ValidationResultDto Add(CountryDto entityDto)
        {
            return base.Add(entityDto);
        }

        public IEnumerable<CountryDto> Teste()
        {
            var lista = _service.GetAll();
            return AutoMapper.Mapper.Map<IEnumerable<COUNTRy>, IEnumerable<CountryDto>>(lista);
            
        }
    }
}
