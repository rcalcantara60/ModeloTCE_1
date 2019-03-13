using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    [Produces("application/json")]
    [Route("api/ProcessoSeletivo")]
    public class ProcessoSeletivoController : BaseCrudController<ProcessoSeletivoDto>
    {
        private readonly IProcessoSeletivoAppService _service;
        public ProcessoSeletivoController(IProcessoSeletivoAppService appService) : base(appService)
        {
            _service = appService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(string numero, string ano, string dataInicio, string dataFim)
        {
            return new OkObjectResult(_service.GetAll(numero, ano, dataInicio, dataFim, Pagination));
        }
    }
}
