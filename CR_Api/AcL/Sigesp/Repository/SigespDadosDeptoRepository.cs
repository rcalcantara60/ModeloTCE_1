using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AcL.Sigesp.Interfaces;
using Domain.Interfaces.Repositories;
using Dto.API.Sigesp;
using AcL.Sigesp.Dto;
using AutoMapper;

namespace AcL.Sigesp.Repository
{
    public class SigespDadosDeptoRepository : ISigespDadosDeptoRepository
    {
        private readonly ISigespDadosDeptoRequestService _sigespDadosDeptoRequestService;
        public SigespDadosDeptoRepository(ISigespDadosDeptoRequestService sigespDadosDeptoRequestService)
        {
            _sigespDadosDeptoRequestService = sigespDadosDeptoRequestService;
        }

        public IEnumerable<LotacaoDto> obterListagemLotacoesAtivas()
        {
            var r = _sigespDadosDeptoRequestService.Get<dynamic, IEnumerable<LotacoesAtivasResponse>>(new { }, @"/departamento/obterListagemLotacoesAtivas");            
            return Mapper.Map<IEnumerable<LotacoesAtivasResponse>,IEnumerable<LotacaoDto>>(r);
        }

        public async Task<IEnumerable<LotacaoDto>> obterListagemLotacoesAtivasAsync(CancellationToken cancellationToken)
        {
            var r = await _sigespDadosDeptoRequestService.GetAsync<IEnumerable<LotacoesAtivasResponse>>(@"/departamento/obterListagemLotacoesAtivas", cancellationToken);
            return Mapper.Map<IEnumerable<LotacoesAtivasResponse>, IEnumerable<LotacaoDto>>(r);
        }
    }
}
