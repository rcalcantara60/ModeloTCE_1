using System;
using System.Data.Entity;
using TCE.Repository.Interfaces;

namespace Context.Base
{
    [DbConfigurationType(typeof(DbConfig))]
    public abstract class BaseContext : DbContext, IDbContext
    {
        public BaseContext(string connectionStringName, DateTime currentUserId) : base(connectionStringName)
        {
            CurrentUserId = currentUserId;
        }

        public BaseContext(string connectionString) : base(connectionString)
        {

        }

        DbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        public DateTime CurrentUserId { get; private set; }
    }
}
