using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services.Comum;
using TCE.CrossCutting.Dto;
using TCE.Repository.Interfaces;
using System.Collections.Generic;
using FluentValidation;
using Domain.Interfaces.Repositories;
using System.Threading.Tasks;
using Dto.API.Sigesp;
using System.Threading;

namespace Domain.Services
{
    public class CountryService : ServiceBaseLocal<COUNTRy>, ICountryService
    {
        protected readonly ISigespDadosPessoaRepository _sigespDadosPessoaRepository;
        protected readonly ISigespDadosDeptoRepository _sigespDadosDeptoRepository;
        public CountryService(IEFRepositoryBase<COUNTRy> repositoryEf,
                                IMicroORMBaseRepository<COUNTRy> repositoryMicroOrm, 
                                IValidator<COUNTRy> v, 
                                ISigespDadosPessoaRepository sigespDadosPessoaRepository,
                                ISigespDadosDeptoRepository sigespDadosDeptoRepository) 
                                            : base(repositoryEf, repositoryMicroOrm, v)
        {
            _sigespDadosPessoaRepository = sigespDadosPessoaRepository;
            _sigespDadosDeptoRepository = sigespDadosDeptoRepository;
        }

        public ValidationResultDto Add(string arquivo, ref long? idArquivo, string extensao)
        {
            var result = new ValidationResultDto { IsValid = true };
            return result;
        }        

        public IEnumerable<COUNTRy> GetAll()
        {
            //POST - http://augita.tce.mg.gov.br:8280/sigespDados/pessoa/consultarPessoasAtivasPorNome/Rodrigo
            var pessoas1 = _sigespDadosPessoaRepository.ConsultarPessoasAtivasPorNome("Rodrigo");
            var pessoas2 =  _sigespDadosPessoaRepository.ConsultaPessoasAtivasPorNomeAsync("Rodrigo", CancellationToken.None).Result;
            //GET - http://augita.tce.mg.gov.br:8280/sigespDados/departamento/obterListagemLotacoesAtivas
            var lotacoes1 = _sigespDadosDeptoRepository.obterListagemLotacoesAtivas();
            var lotacoes2 = _sigespDadosDeptoRepository.obterListagemLotacoesAtivasAsync(CancellationToken.None).Result;
            //POST - http://apim.tce.mg.gov.br:8280/sigespDados/pessoa/consultarGestorDaLotacaoPeloIdLotacao
            var gestor1 = _sigespDadosPessoaRepository.ConsultarGestorDaLotacaoPeloIdLotacao("551839");
            var gestor2 = _sigespDadosPessoaRepository.ConsultarGestorDaLotacaoPeloIdLotacaoAsync("551839", CancellationToken.None).Result;
            
            return null;
        }
    }
}
