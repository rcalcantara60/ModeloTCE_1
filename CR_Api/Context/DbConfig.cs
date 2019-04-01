using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.EntityFramework;
using System.Data.Entity;

namespace Context
{
    public class DbConfig : DbConfiguration
    {   
        public DbConfig()
        {            
            SetProviderServices("Oracle.ManagedDataAccess.Client", EFOracleProviderServices.Instance);
            SetProviderFactory("Oracle.ManagedDataAccess.Client", OracleClientFactory.Instance);
        }
    }
}
