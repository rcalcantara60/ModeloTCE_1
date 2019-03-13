using Domain.Entities;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface IRelatorioCorregedoriaService : IServiceBase<RelatorioCorregedoria>
    {
        IEnumerable<RelatorioCorregedoria> GetAll(string Tipo, string Ano, string Mes, string Trimestre);
    }
}
