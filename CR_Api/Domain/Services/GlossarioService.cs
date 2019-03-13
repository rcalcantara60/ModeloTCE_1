using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;
using System.Linq;
using Domain.Views;

namespace Domain.Services
{
    public class GlossarioService : ServiceBase<Glossario>, IGlossarioService
    {
        public GlossarioService(IEFRepositoryBase<Glossario> repository) : base(repository)
        {
        }

        public IEnumerable<Glossario> GetAll()
        {
            return _repository.All();
        }

        public IEnumerable<GloassarioAgrupado> GetAllAgrupado()
        {
            return _repository.All().OrderBy(o => o.Palavra).ToList().GroupBy(g => g.Palavra[0]).Select(g => new GloassarioAgrupado
            {
                Letra = g.Key,
                Palavras = g.ToList()
            });
        }
    }
}
