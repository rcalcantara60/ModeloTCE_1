using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CountryController : BaseCrudController<CountryDto>
    {
        private readonly ICountryAppService _service;

        public CountryController(ICountryAppService appService) : base(appService)
        {
            _service = appService;
            
        }

        [HttpGet("TesteACL")]
        public IActionResult TesteACL()
        {
            var retorno = _service.Teste();
            return Ok(retorno);
        }
    }
}
