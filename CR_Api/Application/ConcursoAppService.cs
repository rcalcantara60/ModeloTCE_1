using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;

namespace Application
{
    public class ConcursoAppService : AppServiceBaseLocal<Concurso, ConcursoDto>, IConcursoAppService
    {
        private readonly IConcursoService _service;
        public ConcursoAppService(IConcursoService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<ConcursoDto> GetAll(int? numero, int? ano, DateTime? dataInicio, DateTime? dataFim, PaginationDto pagination)
        {
            return Paginate(_service.GetAll(numero, ano, dataInicio, dataFim), pagination);
            //return GetListTDto(_service.GetAll());
        }

        public override ValidationResultDto Add(ConcursoDto entityDto)
        {
            return base.Add(entityDto);
        }
    }
}
