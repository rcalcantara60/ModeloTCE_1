using Domain.Entities;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface IListaTREService : IServiceBase<ListaTRE>
    {
        IEnumerable<ListaTRE> GetAll(string Cpf, string Nome, string Processo, string Municipio);
    }
}
