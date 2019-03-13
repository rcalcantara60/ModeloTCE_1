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

        //public override IActionResult Post([FromBody] CountryDto entityDto)
        //{
        //    return base.Post(entityDto);
        //}
        [HttpGet("")]
        public override IActionResult Get()
        {
            var retorno = _service.Teste();
            return Ok(retorno);
        }
    }
}
