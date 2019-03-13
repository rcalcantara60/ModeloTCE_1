using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;
using System.Linq;

namespace Domain.Services
{
    public class SancaoService : ServiceBase<Sancao>, ISancaoService
    {
        public SancaoService(IEFRepositoryBase<Sancao> repository) : base(repository)
        {
        }

        public IEnumerable<Sancao> GetAll(string anoRefProcesso, string municipioProcesso, string nomeDevedor, string numCpfCgcPte)
        {
            var resposta = _repository.All();
            int ano;
            if (!string.IsNullOrEmpty(anoRefProcesso))
                if (int.TryParse(anoRefProcesso.ToString(), out ano))
                    resposta = resposta.Where(t => t.anoRefProcesso == ano);
            if (!string.IsNullOrEmpty(municipioProcesso))
                resposta = resposta.Where(t => t.municipioProcesso.ToUpper().Contains(municipioProcesso.ToUpper()));
            if (!string.IsNullOrEmpty(nomeDevedor))
                resposta = resposta.Where(t => t.nomeDevedor.ToUpper().Contains(nomeDevedor.ToUpper()));
            if (!string.IsNullOrEmpty(numCpfCgcPte))
                resposta = resposta.Where(t => t.numCpfCgcPte.Contains(numCpfCgcPte));

            return resposta;
        }
    }
}
