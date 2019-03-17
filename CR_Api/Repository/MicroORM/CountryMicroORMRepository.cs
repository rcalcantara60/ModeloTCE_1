using System.Collections.Generic;
using Domain.Interfaces.Repositories;
//using Utils;
using Domain.Entities;
using TCE.Repository.Base;
using TCE.Repository.Interfaces;

namespace Repository.MicroORM
{

   

    public class CountryMicroORMRepository : MicroORMBaseRepository<COUNTRy>, ICountryMircroORMRepository
    {
        public CountryMicroORMRepository(IDbConnectionFactory dbConnectionFactory):base(dbConnectionFactory)
        {
            base.DbConnectionDefault = base.DbConnectionFactory.CreateDbConnection("ConnectionString");
        }
        public IEnumerable<T> GetCountry<T>() where T : class
        {
            IEnumerable<T> countries = base.GetAll<T>("select * from countries");
            
            return countries;
        }

        public IEnumerable<COUNTRy> GetCountry()
        {

            var a = base.GetAllWithParam("select * from countries c where c.region_id = :region_id", new List<dynamic> {new { region_id = 3 }});

            IEnumerable<COUNTRy> countries = base.GetAll("select * from countries");

            return countries;
        }

        public IEnumerable<COUNTRy> GetCountryOutraConn()
        {
            IEnumerable<COUNTRy> countries = base.GetAll("select * from countries", "");

            return countries;
        }
    }
}
