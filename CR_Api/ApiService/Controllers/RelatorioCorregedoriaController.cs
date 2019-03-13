using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    [Produces("application/json")]
    [Route("api/RelatorioCorregedoria")]
    public class RelatorioCorregedoriaController : BaseCrudController<RelatorioCorregedoriaDto>
    {
        private readonly IRelatorioCorregedoriaAppService _service;
        public RelatorioCorregedoriaController(IRelatorioCorregedoriaAppService appService) : base(appService)
        {
            _service = appService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(string Tipo, string Ano, string Mes, string Trimestre)
        {
            return new OkObjectResult(_service.GetAll(Tipo, Ano, Mes, Trimestre, Pagination));
        }
    }
}
