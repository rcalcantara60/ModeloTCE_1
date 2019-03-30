using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services.Comum;
using TCE.CrossCutting.Dto;
using TCE.Repository.Interfaces;
using System.Collections.Generic;
using FluentValidation;

namespace Domain.Services
{
    public class CountryService : ServiceBaseLocal<COUNTRy>, ICountryService
    {           
        public CountryService(IEFRepositoryBase<COUNTRy> repositoryEf, IMicroORMBaseRepository<COUNTRy> repositoryMicroOrm, IValidator<COUNTRy> v) : base(repositoryEf, repositoryMicroOrm, v)
        {   
            
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
            //var a = _countryRepository.GetCountry();
            //var b = _countryRepository.GetCountry<COUNTRy>();
            //var c = _countryRepository.GetCountryOutraConn();

            return RepositoryMicroOrm.GetAll("SELECT * FROM COUNTRIES");
        }
    }
}
