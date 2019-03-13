using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    //[EnableCors("AllowAllMethods")]
    [Produces("application/json")]
    //[Route("api/Indicador")]
    public class IndicadorController : BaseCrudController<IndicadorDto>
    {
        private readonly IIndicadorAppService _service;
        public IndicadorController(IIndicadorAppService appService) : base(appService)
        {
            _service = appService;
        }

        [HttpGet("GetAllCategoria")]
        public IActionResult GetAllCategoria()
        {
            return new OkObjectResult(_service.GetAllCategoria());
        }

        [HttpGet("GetAllSituacao")]
        public IActionResult GetAllSituacao()
        {
            return new OkObjectResult(_service.GetAllSituacao());
        }

        [HttpGet("GetAllStatus")]
        public IActionResult GetAllStatus()
        {
            return new OkObjectResult(_service.GetAllStatus());
        }
    }
}
