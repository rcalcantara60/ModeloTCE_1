using Domain.Entities;
using Domain.Interfaces.Services.Comum;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface ICountryService : IServiceBaseLocal<COUNTRy>
    {        
        ValidationResultDto Add(string arquivo, ref long? idArquivo, string extensao);

        IEnumerable<COUNTRy> GetAll();
        
    }
}