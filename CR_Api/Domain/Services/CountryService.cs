using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services.Comum;
using System;
using TCE.CrossCutting.Dto;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;

using System.Collections.Generic;
using System.Data.Entity;
using Domain.Interfaces.Repositories;

namespace Domain.Services
{
    public class CountryService : ServiceBaseLocal<COUNTRy>, ICountryService
    {
        private readonly ICountryMircroORMRepository _countryRepository;
        public CountryService(IEFRepositoryBase<COUNTRy> repository, ICountryMircroORMRepository countryRepository) : base(repository)
        {
            _countryRepository = countryRepository;
        }

        public ValidationResultDto Add(string arquivo, ref long? idArquivo, string extensao)
        {
            var result = new ValidationResultDto { IsValid = true };
            //var documento = GetArquivo(arquivo);
            //if (documento != null)
            //{
            //    result = Add(documento);
            //}
            return result;
        }

        public IEnumerable<COUNTRy> GetAll()
        {
            var a = _countryRepository.GetCountry();
            var b = _countryRepository.GetCountry<COUNTRy>();
            var c = _countryRepository.GetCountryOutraConn();

            return _countryRepository.GetCountry<COUNTRy>();
        }
    }
}
