using System;
using TCE.DomainLayerBase.Entities;

namespace Domain.Entities.Comum
{
    public abstract class EntityBaseLocal<TEntity> : EntityBase<TEntity> where TEntity : class
    {
        public EntityBaseLocal()
        {

        }
    }
}
