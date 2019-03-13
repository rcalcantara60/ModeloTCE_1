using Application.Comum;
using Application.Dto;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;

namespace Application
{
    public class ListaTREAppService : AppServiceBaseLocal<ListaTRE, ListaTREDto>, IListaTREAppService
    {
        private readonly IListaTREService _service;
        public ListaTREAppService(IListaTREService service) : base(service)
        {
            _service = service;
        }

        public IEnumerable<ListaTREDto> GetAll(string Cpf, string Nome, string Processo, string Municipio, PaginationDto Pagination)
        {
            return Paginate(_service.GetAll(Cpf, Nome, Processo, Municipio), Pagination);
        }

        public override ValidationResultDto Add(ListaTREDto entityDto)
        {
            return base.Add(entityDto);
        }
    }
}
