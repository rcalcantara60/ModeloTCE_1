using Domain.Interfaces.Services;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;

namespace Domain.Services.Comum
{
    public abstract class ServiceBaseLocal<T> : ServiceBase<T> where T : class
    {        
        public ServiceBaseLocal(IEFRepositoryBase<T> repository) : base(repository)
        {
        }        
    }
}
