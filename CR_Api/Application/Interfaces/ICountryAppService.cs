using Application.Dto;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;

namespace Application.Interfaces
{
    public interface ICountryAppService : IAppServiceBase<CountryDto>
    {
        IEnumerable<CountryDto> Teste();
    }
}
