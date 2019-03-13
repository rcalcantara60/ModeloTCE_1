using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;

namespace Application
{
    public class FaqAppService : AppServiceBaseLocal<Faq, FaqDto>, IFaqAppService
    {
        private readonly IFaqService _service;
        public FaqAppService(IFaqService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<FaqDto> GetAll()
        {
            return GetListTDto(_service.GetAll());
        }

        public override ValidationResultDto Add(FaqDto entityDto)
        {
            return base.Add(entityDto);
        }
    }
}
