using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    [Produces("application/json")]
    [Route("api/ListaTRE")]
    public class ListaTREController : BaseCrudController<ListaTREDto>
    {
        private readonly IListaTREAppService _service;
        public ListaTREController(IListaTREAppService appService) : base(appService)
        {
            _service = appService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(string Cpf, string Nome, string Processo, string Municipio)
        {
            return new OkObjectResult(_service.GetAll(Cpf, Nome, Processo, Municipio, Pagination));
        }
    }
}
