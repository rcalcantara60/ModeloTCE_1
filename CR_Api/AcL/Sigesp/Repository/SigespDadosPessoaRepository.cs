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
    public class SigespDadosPessoaRepository : ISigespDadosPessoaRepository
    {
        private readonly ISigespDadosPessoaRequestService _sigespDadosPessoaRequestService;
        public SigespDadosPessoaRepository(ISigespDadosPessoaRequestService sigespDadosPessoaRequestService)
        {
            _sigespDadosPessoaRequestService = sigespDadosPessoaRequestService;
        }

        public async Task<IEnumerable<PessoaDto>> ConsultaPessoasAtivasPorNomeAsync(string nome, CancellationToken cancellationToken)
        {
            var r = await _sigespDadosPessoaRequestService.PostAsync<dynamic, IEnumerable<PessoasAtivasResponse>>(new { }, @"/pessoa/consultarPessoasAtivasPorNome/"+nome, cancellationToken);
            return Mapper.Map<IEnumerable<PessoasAtivasResponse>, IEnumerable<PessoaDto>>(r);
        }

        public IEnumerable<PessoaDto> ConsultarPessoasAtivasPorNome(string nome)
        {
            var r = _sigespDadosPessoaRequestService.Post<dynamic, IEnumerable<PessoasAtivasResponse>>(new { }, @"/pessoa/consultarPessoasAtivasPorNome/" + nome);
            return Mapper.Map<IEnumerable<PessoasAtivasResponse>, IEnumerable<PessoaDto>>(r);
        }

        public GestorLotacaoDto ConsultarGestorDaLotacaoPeloIdLotacao(string idLotacao)
        {
            var r = _sigespDadosPessoaRequestService.Post<dynamic, GestorLotacaoResponse>(new { idLotacao = idLotacao }, @"/pessoa/consultarGestorDaLotacaoPeloIdLotacao/");
            return Mapper.Map<GestorLotacaoResponse, GestorLotacaoDto>(r);
        }

        public async Task<GestorLotacaoDto> ConsultarGestorDaLotacaoPeloIdLotacaoAsync(string idLotacao, CancellationToken cancellationToken)
        {

            var r = await _sigespDadosPessoaRequestService.PostAsync<dynamic, GestorLotacaoResponse>(new { idLotacao = idLotacao }, @"/pessoa/consultarGestorDaLotacaoPeloIdLotacao/", cancellationToken);
            return Mapper.Map<GestorLotacaoResponse, GestorLotacaoDto>(r);
        }
    }
}
