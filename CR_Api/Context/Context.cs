using Context.Base;
using Context.Mappings;
using Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;

namespace Context
{
    public partial class Context : BaseContext
    {
        static Context()
        {
            //Caso execute Feed da base
            Database.SetInitializer<Context>(null);
        }

        public Context()
            : base("Name=Context", DateTime.Now)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = true;
        }

        public Context(string conn)
            : base(conn, DateTime.Now)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<COUNTRy> Country { get; set; }
        public DbSet<EMP_DETAILS_VIEW> EmpDetailsView { get; set; }
        public DbSet<EMPLOYEE> Employee { get; set; }
        public DbSet<JOB_HISTORY> JobHistory { get; set; }
        public DbSet<LOCATION> Location { get; set; }
        public DbSet<REGION> Region { get; set; }
        public DbSet<DEPARTMENT> Department { get; set; }
        public DbSet<JOB> Job { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            
            modelBuilder.Configurations.Add(new COUNTRyMap());
            modelBuilder.Configurations.Add(new EMP_DETAILS_VIEWMap());
            modelBuilder.Configurations.Add(new EMPLOYEEMap());
            modelBuilder.Configurations.Add(new JOB_HISTORYMap());
            modelBuilder.Configurations.Add(new LOCATIONMap());
            modelBuilder.Configurations.Add(new REGIONMap());
            modelBuilder.Configurations.Add(new DEPARTMENTMap());
            modelBuilder.Configurations.Add(new JOBMap());


            base.OnModelCreating(modelBuilder);
            modelBuilder.Properties<string>().Configure(x => x.IsUnicode(true));
            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("VARCHAR2"));
            Database.Log = (query) => Debug.Write(query);
        }

        public override int SaveChanges()
        {
            var changeSet = ChangeTracker.Entries();
            foreach (var entry in changeSet)
            {
                if (entry.State.Equals(EntityState.Added) && entry.Entity.GetType().GetProperty("DataCadastro") != null)
                {
                    entry.Entity.GetType().GetProperty("DataCadastro").SetValue(entry.Entity, DateTime.Now);
                }
            }
            return base.SaveChanges();
        }
    }
}
