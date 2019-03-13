using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;

namespace Application
{
    public class SancaoAppService : AppServiceBaseLocal<Sancao, SancaoDto>, ISancaoAppService
    {
        private readonly ISancaoService _service;
        public SancaoAppService(ISancaoService service) : base(service)
        {
            _service = service;
        }

        public  IEnumerable<SancaoDto> GetAll(string anoRefProcesso, string municipioProcesso, string nomeDevedor, string numCpfCgcPte, PaginationDto pagination)
        {
            return Paginate(_service.GetAll(anoRefProcesso, municipioProcesso, nomeDevedor, numCpfCgcPte), pagination);
            //return GetListTDto(_service.GetAll(anoRefProcesso, municipioProcesso, nomeDevedor, numCpfCgcPte));
        }

        public override ValidationResultDto Add(SancaoDto entityDto)
        {
            return base.Add(entityDto);
        }
    }
}
