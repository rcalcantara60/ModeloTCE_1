using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;
using System.Linq;
using System;

namespace Domain.Services
{
    public class ConcursoService : ServiceBase<Concurso>, IConcursoService
    {
        public ConcursoService(IEFRepositoryBase<Concurso> repository) : base(repository)
        {
        }

        public IEnumerable<Concurso> GetAll(int? numero, int? ano, DateTime? dataInicio, DateTime? dataFim)
        {
            var resposta = _repository.All();

            if (ano != null)
                resposta = resposta.Where(t => t.Ano == ano);
            if (numero != null)
                resposta = resposta.Where(t => t.Numero == numero);

            if (dataInicio != null)
                resposta = resposta.Where(t => t.DataInicio >= dataInicio);
            if (dataFim != null)
                resposta = resposta.Where(t => t.DataFim <= dataFim);

            return resposta;

        }
    }
}
