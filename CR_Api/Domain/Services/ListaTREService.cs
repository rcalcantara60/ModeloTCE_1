using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;
using System.Linq;

namespace Domain.Services
{
    public class ListaTREService : ServiceBase<ListaTRE>, IListaTREService
    {
        public ListaTREService(IEFRepositoryBase<ListaTRE> repository) : base(repository)
        {
        }

        public IEnumerable<ListaTRE> GetAll(string Cpf, string Nome, string Processo, string Municipio)
        {
            var resposta = _repository.All();
            
            if (!string.IsNullOrEmpty(Cpf))
                resposta = resposta.Where(t => t.Cpf.Contains(Cpf));

            if (!string.IsNullOrEmpty(Nome))
                resposta = resposta.Where(t => t.Nome.ToLower().Contains(Nome.ToLower()));
            
            int processo;
            if (!string.IsNullOrEmpty(Processo))
                if (int.TryParse(Processo.ToString(), out processo))
                    resposta = resposta.Where(t => t.Processo == processo);

            if (!string.IsNullOrEmpty(Municipio))
                resposta = resposta.Where(t => t.Municipio.Contains(Municipio));

            return resposta;
        }
    }
}
