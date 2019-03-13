using Application.Dto;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;
using TCE.CrossCutting.Dto;

namespace Application.Interfaces
{
    public interface ISancaoAppService : IAppServiceBase<SancaoDto>
    {
        IEnumerable<SancaoDto> GetAll(string anoRefProcesso, string municipioProcesso, string nomeDevedor, string numCpfCgcPte, PaginationDto Pagination);
    }
}
