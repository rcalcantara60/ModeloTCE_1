using System.Collections.Generic;
using Utils;

namespace Domain.Interfaces.Repositories
{
    public interface IMicroORMBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(string sql);
        IEnumerable<T> GetAll<T>(string sql) where T : class;
        IEnumerable<TEntity> GetAll(string sql, ConnectionsName connectionsName);
        IEnumerable<T> GetAll<T>(string sql, ConnectionsName connectionsName) where T : class;
        IEnumerable<TEntity> GetAllWithParam(string sql, IEnumerable<dynamic> parameters);
        IEnumerable<T> GetAllWithParam<T>(string sql, IEnumerable<dynamic> parameters) where T : class;
        IEnumerable<TEntity> GetAllWithParam(string sql, ConnectionsName connectionsName, IEnumerable<dynamic> parameters);
        IEnumerable<T> GetAllWithParam<T>(string sql, ConnectionsName connectionsName, IEnumerable<dynamic> parameters) where T : class;        

    }
}
