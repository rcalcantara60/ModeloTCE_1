using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Application.Views;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;

namespace Application
{
    public class GlossarioAppService : AppServiceBaseLocal<Glossario, GlossarioDto>, IGlossarioAppService
    {
        private readonly IGlossarioService _service;
        public GlossarioAppService(IGlossarioService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<GlossarioDto> GetAll()
        {
            return GetListTDto(_service.GetAll());
        }

        public IEnumerable<GloassarioAgrupadoDto> GetAllAgrupado()
        {
          return  AutoMapper.Mapper.Map<IEnumerable<GloassarioAgrupadoDto>>(_service.GetAllAgrupado());            
        }

        public override ValidationResultDto Add(GlossarioDto entityDto)
        {
            return base.Add(entityDto);
        }
    }
}
