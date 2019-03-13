using Application.Dto;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;

namespace Application.Interfaces
{
    public interface IIndicadorAppService : IAppServiceBase<IndicadorDto>
    {
        IndicadorDto GetIndicador(long id);
        IndicadorDto GetEmAnalise();
        IndicadorDto GetProcessando();
        IndicadorDto GetRecusado();
        IndicadorDto GetConcluido();

        IEnumerable<IndicadorDto> GetAllCategoria();
        IEnumerable<IndicadorDto> GetAllSituacao();
        IEnumerable<IndicadorDto> GetAllStatus();
    }
}
