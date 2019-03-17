using Application;
using Application.Interfaces;
using Context;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services;
using Repository.MicroORM;
using SimpleInjector;
using System.Collections.Generic;
using TCE.Aop;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Base;
using TCE.Repository.Core;
using TCE.Repository.Interfaces;
//using Utils;

namespace IoC
{
    public static class InjectorContainer
    {

        private static readonly ProxyFactory Factory;

        static InjectorContainer()
        {
            Factory = new ProxyFactory();
        }

        public static Container GetContainer()
        {
            return new Container();
        }

        private static T Generate<T>(Container container)
        {
            var pars = typeof(T).GetConstructors()[0].GetParameters();
            var arr = new object[pars.Length];
            for (var i = 0; i < pars.Length; i++)
            {
                arr[i] = container.GetInstance(pars[i].ParameterType);
            }
            var proxy = Factory.CreateClassProxy(arr, typeof(T), new TransactionInterceptor());
            return (T)proxy;
        }

        public static Container RegistrarServicos(Container container, ScopedLifestyle scoped, string connString, Dictionary<string, string> d)
        {   
            container.Register<IDbContext>(() => new Context.Context(connString), Lifestyle.Scoped);
            container.Register<IContextManager, ContextManager>(Lifestyle.Scoped);
            container.Register(typeof(IEFRepositoryBase<>), typeof(EFRepositoryBase<>), Lifestyle.Scoped);
            container.Register(typeof(IMicroORMBaseRepository<>), typeof(MicroORMBaseRepository<>), Lifestyle.Scoped);
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);

           

            container.Register<ICountryService, CountryService>(Lifestyle.Scoped);
            container.Register<ICountryAppService, CountryAppService>(Lifestyle.Scoped);
            container.Register<ICountryMircroORMRepository, CountryMicroORMRepository>(Lifestyle.Scoped);

            container.Register<IDbConnectionFactory, DbConnectionFactory>(Lifestyle.Scoped);

            container.RegisterSingleton<IDictionary<string, string>>(d);

            return container;
        }
    }
}
