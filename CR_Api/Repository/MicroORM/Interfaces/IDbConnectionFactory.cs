using System.Data;
using Utils;

namespace Repository.MicroORM.Interfaces
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateDbConnection(ConnectionsName connectionsName);
    }
}
