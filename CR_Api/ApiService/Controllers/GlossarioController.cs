using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    [Produces("application/json")]
    [Route("api/Glossario")]
    public class GlossarioController : BaseCrudController<GlossarioDto>
    {
        private readonly IGlossarioAppService _service;
        public GlossarioController(IGlossarioAppService appService) : base(appService)
        {
            _service = appService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return new OkObjectResult(_service.GetAll());
        }

        [HttpGet("GetAllAgrupado")]
        public IActionResult GetAllAgrupado()
        {
            return new OkObjectResult(_service.GetAllAgrupado());
        }
    }
}
