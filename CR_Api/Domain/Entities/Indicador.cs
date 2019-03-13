using Domain.Entities.Comum;
using System;
using System.Collections.Generic;
using TCE.Repository.Interfaces;
using TCE.DomainLayerBase.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Indicador : EntityBaseLocal<Indicador>
    {
        public long IdTipoIndicador { get; private set; }
        public virtual TipoIndicador TipoIndicador { get; private set; }
        public string SglIndicador { get; private set; }
        public string DscIndicador { get; private set; }
        public virtual ICollection<Arquivo> ArquivosCategoria { get; private set; }
        public virtual ICollection<Arquivo> ArquivosSituacao { get; private set; }
        public virtual ICollection<Arquivo> ArquivosStatus { get; private set; }

        public Indicador()
        {
            ArquivosCategoria = new HashSet<Arquivo>();
            ArquivosSituacao = new HashSet<Arquivo>();
            ArquivosStatus = new HashSet<Arquivo>();
        }

        public override bool IsValidToAdd(IServiceBase<Indicador> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<Indicador> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToDelete(IServiceBase<Indicador> service)
        {
            throw new NotImplementedException();
        }
    }
}
