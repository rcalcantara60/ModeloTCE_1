using Domain.Entities;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface IProcessoSeletivoService : IServiceBase<ProcessoSeletivo>
    {
        IEnumerable<ProcessoSeletivo> GetAll(string numero, string ano, string dataInicio, string dataFim);
    }
}
