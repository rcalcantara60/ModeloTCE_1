using Domain.Entities;
using System.Collections.Generic;
using TCE.Repository.Interfaces;

namespace Domain.Interfaces.Repositories
{
    public interface ICountryMircroORMRepository: IMicroORMBaseRepository<COUNTRy>
    {
        IEnumerable<T> GetCountry<T>() where T : class;
        IEnumerable<COUNTRy> GetCountry();
        IEnumerable<COUNTRy> GetCountryOutraConn();
    }
}
