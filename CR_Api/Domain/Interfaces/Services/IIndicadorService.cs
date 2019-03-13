using Domain.Entities;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface IIndicadorService : IServiceBase<Indicador>
    {
        Indicador GetIndicador(long id);
        Indicador GetEmAnalise();
        Indicador GetProcessando();
        Indicador GetRecusado();
        Indicador GetConcluido();

        IEnumerable<Indicador> GetAllCategoria();
        IEnumerable<Indicador> GetAllSituacao();
        IEnumerable<Indicador> GetAllStatus();
    }
}
