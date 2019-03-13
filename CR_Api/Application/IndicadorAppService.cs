using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Application
{
    public class IndicadorAppService : AppServiceBaseLocal<Indicador, IndicadorDto>, IIndicadorAppService
    {
        private readonly IIndicadorService _service;
        public IndicadorAppService(IIndicadorService service) : base(service)
        {
            _service = service;
        }

        public IndicadorDto GetIndicador(long id)
        {
            return GetTDto(_service.GetSingle((int)id));
        }

        public IndicadorDto GetEmAnalise()
        {
            return GetTDto(_service.GetEmAnalise());
        }

        public IndicadorDto GetProcessando()
        {
            return GetTDto(_service.GetProcessando());
        }

        public IndicadorDto GetRecusado()
        {
            return GetTDto(_service.GetRecusado());
        }

        public IndicadorDto GetConcluido()
        {
            return GetTDto(_service.GetConcluido());
        }

        public IEnumerable<IndicadorDto> GetAllCategoria()
        {
            return GetListTDto(_service.GetAllCategoria());
        }

        public IEnumerable<IndicadorDto> GetAllSituacao()
        {
            return GetListTDto(_service.GetAllSituacao());
        }

        public IEnumerable<IndicadorDto> GetAllStatus()
        {
            return GetListTDto(_service.GetAllStatus());
        }
    }
}
