using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    [Produces("application/json")]
    [Route("api/Sancao")]
    public class SancaoController : BaseCrudController<SancaoDto>
    {
        private readonly ISancaoAppService _service;
        public SancaoController(ISancaoAppService appService) : base(appService)
        {
            _service = appService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(string anoRefProcesso, string municipioProcesso, string nomeDevedor, string numCpfCgcPte)
        {
            return new OkObjectResult(_service.GetAll(anoRefProcesso, municipioProcesso, nomeDevedor, numCpfCgcPte, Pagination));
        }
    }
}
