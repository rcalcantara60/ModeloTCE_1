using Application.Interfaces;
using TCE.AppLayerBase.Base;
using TCE.DomainLayerBase.Base;

namespace Application.Comum
{
    public abstract class AppServiceBaseLocal<TEntity, TDto> : AppServiceBase<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        public AppServiceBaseLocal(IServiceBase<TEntity> service) : base(service)
        {
        }
    }
}
