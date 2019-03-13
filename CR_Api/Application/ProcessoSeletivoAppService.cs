using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;

namespace Application
{
    public class ProcessoSeletivoAppService : AppServiceBaseLocal<ProcessoSeletivo, ProcessoSeletivoDto>, IProcessoSeletivoAppService
    {
        private readonly IProcessoSeletivoService _service;
        public ProcessoSeletivoAppService(IProcessoSeletivoService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<ProcessoSeletivoDto> GetAll(string numero, string ano, string dataInicio, string dataFim, PaginationDto pagination)
        {
            return Paginate(_service.GetAll(numero, ano, dataInicio, dataFim), pagination);
            //return GetListTDto(_service.GetAll());
        }

        public override ValidationResultDto Add(ProcessoSeletivoDto entityDto)
        {
            return base.Add(entityDto);
        }
    }
}
