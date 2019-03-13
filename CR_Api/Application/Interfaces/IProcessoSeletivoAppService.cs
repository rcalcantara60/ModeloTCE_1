using Application.Dto;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;
using TCE.CrossCutting.Dto;

namespace Application.Interfaces
{
    public interface IProcessoSeletivoAppService : IAppServiceBase<ProcessoSeletivoDto>
    {
        IEnumerable<ProcessoSeletivoDto> GetAll(string numero, string ano, string dataInicio, string dataFim, PaginationDto pagination);
    }
}
