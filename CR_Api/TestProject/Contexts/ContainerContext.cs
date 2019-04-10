using Context;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services;
using Domain.Validators;
using FluentValidation;
using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;
using System;
using System.Collections.Generic;
using System.Text;
using TCE.Repository.Base;
using TCE.Repository.Core;
using TCE.Repository.Interfaces;

namespace TestProject.Contexts
{
    public class ContainerContext : IDisposable
    {
        private bool _disposed;
        private readonly Container container = new Container();

        public ContainerContext()
        {            
            container.Options.AllowOverridingRegistrations = true;
            container.Options.DefaultLifestyle = Lifestyle.Singleton;

            container.Register<IDbContext>(() => new Context.Context("DATA SOURCE=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP) (Host = 172.30.8.18) (Port = 1521) ) ) (CONNECT_DATA = (SID = hml02) ) );PASSWORD=123;PERSIST SECURITY INFO=True;POOLING=False;USER ID=HR_R", "HR_R"));
            container.Register<IContextManager, ContextManager>();
            container.Register(typeof(IEFRepositoryBase<>), typeof(EFRepositoryBase<>));
            container.Register(typeof(IMicroORMBaseRepository<>), typeof(MicroORMBaseRepository<>));



            container.Register<IValidator<COUNTRy>, CountryValidator>();
            container.Register<IValidator<REGION>, RegionValidator>();

            container.Register<ICountryService, CountryService>();

            container.Register<IRegionService, RegionService>();

            container.Register<IDbConnectionFactory, DbConnectionFactory>();
        }

        public T GetService<T>()
                where T : class
        {
            var service = container.GetInstance<T>();
            return service;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    container.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
