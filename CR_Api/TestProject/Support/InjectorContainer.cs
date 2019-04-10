using Context;
using Domain.Entities;
using Domain.Validators;
using Domain.Services;
using FluentValidation;
using SimpleInjector;
using TCE.Repository.Base;
using TCE.Repository.Interfaces;
using Domain.Interfaces.Services;
using TCE.Repository.Core;

namespace TestProject.Support
{
    public static class InjectorContainer
    {
        public static Container RegistrarServicos()
        {
            Container container = new Container();
            
            container.Register<IDbContext>(() => new Context.Context("", ""), Lifestyle.Scoped);
            container.Register<IContextManager, ContextManager>(Lifestyle.Scoped);
            container.Register(typeof(IEFRepositoryBase<>), typeof(EFRepositoryBase<>), Lifestyle.Scoped);
            container.Register(typeof(IMicroORMBaseRepository<>), typeof(MicroORMBaseRepository<>), Lifestyle.Scoped);



            container.Register<IValidator<COUNTRy>, CountryValidator>(Lifestyle.Scoped);
            container.Register<IValidator<REGION>, RegionValidator>(Lifestyle.Scoped);

            container.Register<ICountryService, CountryService>(Lifestyle.Scoped);

            container.Register<IRegionService, RegionService>(Lifestyle.Scoped);

            container.Register<IDbConnectionFactory, DbConnectionFactory>(Lifestyle.Scoped);



            return container;
        }
    }
}
