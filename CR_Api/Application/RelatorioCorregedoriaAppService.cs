using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;

namespace Application
{
    public class RelatorioCorregedoriaAppService : AppServiceBaseLocal<RelatorioCorregedoria, RelatorioCorregedoriaDto>, IRelatorioCorregedoriaAppService
    {
        private readonly IRelatorioCorregedoriaService _service;
        public RelatorioCorregedoriaAppService(IRelatorioCorregedoriaService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<RelatorioCorregedoriaDto> GetAll(string Tipo, string Ano, string Mes, string Trimestre, PaginationDto pagination)
        {
            return Paginate(_service.GetAll(Tipo, Ano, Mes, Trimestre), pagination);
            //return GetListTDto(_service.GetAll(Tipo, Ano, Mes, Trimestre));
        }

        public override ValidationResultDto Add(RelatorioCorregedoriaDto entityDto)
        {
            return base.Add(entityDto);
        }
    }
}
