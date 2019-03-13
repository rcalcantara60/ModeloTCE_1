using Domain.Entities;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface ISancaoService : IServiceBase<Sancao>
    {
        IEnumerable<Sancao> GetAll(string anoRefProcesso, string municipioProcesso, string nomeDevedor, string numCpfCgcPte);
    }
}
