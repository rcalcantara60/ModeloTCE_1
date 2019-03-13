using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface ICountryMircroORMRepository: IMicroORMBaseRepository<COUNTRy>
    {
        IEnumerable<T> GetCountry<T>() where T : class;
        IEnumerable<COUNTRy> GetCountry();
        IEnumerable<COUNTRy> GetCountryOutraConn();
    }
}
