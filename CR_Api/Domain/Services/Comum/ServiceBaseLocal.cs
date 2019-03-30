using Domain.Interfaces.Services;
using FluentValidation;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;

namespace Domain.Services.Comum
{
    public abstract class ServiceBaseLocal<T> : ServiceBase<T> where T : class
    {        
        public ServiceBaseLocal(IEFRepositoryBase<T> repository, IMicroORMBaseRepository<T> repositoryMicroOrm, IValidator<T> v) : base(repository, repositoryMicroOrm, v)
        {
        }        
    }
}
