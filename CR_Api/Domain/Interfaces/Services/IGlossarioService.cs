using Domain.Entities;
using Domain.Views;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface IGlossarioService : IServiceBase<Glossario>
    {
        IEnumerable<Glossario> GetAll();
        IEnumerable<GloassarioAgrupado> GetAllAgrupado();
    }
}
