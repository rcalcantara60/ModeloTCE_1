using Application.Dto;
using Application.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using TCE.Web.Api.Base;

namespace ApiService.Controllers
{
    //[EnableCors("AllowAllMethods")]
    [Produces("application/json")]
    [Route("api/Concurso")]
    public class ConcursoController : BaseCrudController<ConcursoDto>
    {
        private readonly IConcursoAppService _service;
        public ConcursoController(IConcursoAppService appService) : base(appService)
        {
            _service = appService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(int? numero, int? ano, DateTime? dataInicio, DateTime? dataFim)
        {
            return new OkObjectResult(_service.GetAll(numero, ano, dataInicio, dataFim, Pagination));
        }
        [HttpGet("GetHeader")]
        public string GetHeader()
        {
            var url = Request.Headers["Referer"].ToString();
            var ip = Request.HttpContext.Connection.RemoteIpAddress;
            return string.Format("URL: {0} - IP: {1}",url,ip);
        }
    }
}
