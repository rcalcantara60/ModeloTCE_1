using Oracle.ManagedDataAccess.Client;
using Repository.MicroORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using Utils;

namespace Repository.MicroORM.Core
{
    public class DbConnectionFactory : Repository.MicroORM.Interfaces.IDbConnectionFactory
    {
        private readonly IDictionary<ConnectionsName, string> _connDict;

        public DbConnectionFactory(IDictionary<ConnectionsName, string> connDict)
        {
            _connDict = connDict;
        }

        public IDbConnection CreateDbConnection(ConnectionsName connectionsName)
        {
            string connectionString = null;
            if (_connDict.TryGetValue(connectionsName, out connectionString))
            {
                return new  OracleConnection(connectionString);
            }

            throw new Exception("Não foi possivel criar uma conexão.");
        }
    }
}
