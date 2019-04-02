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
            var r = _sigespDadosPessoaRepository.ConsultarPessoasAtivasPorNome("Rodrigo");
            var rr =  _sigespDadosPessoaRepository.ConsultaPessoasAtivasPorNomeAsync("Rodrigo", CancellationToken.None);
            //var rrr = _sigespDadosDeptoRepository.obterListagemLotacoesAtivas();
            //var rrrr = _sigespDadosDeptoRepository.obterListagemLotacoesAtivasAsync(CancellationToken.None);
            Task.WaitAll(rr);
            //Task.WaitAll(rrrr);
            return null;
        }
    }
}
