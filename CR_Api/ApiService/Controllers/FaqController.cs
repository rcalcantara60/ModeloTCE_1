using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    [Produces("application/json")]
    [Route("api/Faq")]
    public class FaqController : BaseCrudController<FaqDto>
    {
        private readonly IFaqAppService _service;
        public FaqController(IFaqAppService appService) : base(appService)
        {
            _service = appService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return new OkObjectResult(_service.GetAll());
        }
    }
}
