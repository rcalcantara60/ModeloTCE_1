using Domain.Entities.Comum;
using System;
using System.Collections.Generic;
using TCE.Repository.Interfaces;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public class TipoIndicador : EntityBaseLocal<TipoIndicador>
    {
        public string NomTipoIndicador { get; private set; }
        public virtual ICollection<Indicador> Indicadores { get; private set; }

        public TipoIndicador()
        {
            Indicadores = new HashSet<Indicador>();
        }

        public override bool IsValidToAdd(IServiceBase<TipoIndicador> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<TipoIndicador> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToDelete(IServiceBase<TipoIndicador> service)
        {
            throw new NotImplementedException();
        }
    }
}
