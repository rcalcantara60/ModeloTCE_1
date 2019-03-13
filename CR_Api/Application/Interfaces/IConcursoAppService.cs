using Application.Dto;
using System;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;
using TCE.CrossCutting.Dto;

namespace Application.Interfaces
{
    public interface IConcursoAppService : IAppServiceBase<ConcursoDto>
    {
        IEnumerable<ConcursoDto> GetAll(int? numero, int? ano, DateTime? dataInicio, DateTime? dataFim, PaginationDto pagination);
    }
}
