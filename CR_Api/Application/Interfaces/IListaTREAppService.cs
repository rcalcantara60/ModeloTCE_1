using Application.Dto;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;
using TCE.CrossCutting.Dto;

namespace Application.Interfaces
{
    public interface IListaTREAppService : IAppServiceBase<ListaTREDto>
    {
        IEnumerable<ListaTREDto> GetAll(string Cpf, string Nome, string Processo, string Municipio, PaginationDto Pagination);
    }
}
