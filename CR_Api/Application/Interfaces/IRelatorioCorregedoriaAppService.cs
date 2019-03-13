using Application.Dto;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;
using TCE.CrossCutting.Dto;

namespace Application.Interfaces
{
    public interface IRelatorioCorregedoriaAppService : IAppServiceBase<RelatorioCorregedoriaDto>
    {
        IEnumerable<RelatorioCorregedoriaDto> GetAll(string Tipo, string Ano, string Mes, string Trimestre, PaginationDto pagination);
    }
}
