using System.Web;
using TCE.Repository.Interfaces;

namespace Context
{
    public class ContextManager : IContextManager
    {
        private readonly string ContextKey;
        private readonly IDbContext _dbContext;

        public ContextManager(IDbContext dbContext)
        {
            _dbContext = dbContext;
            ContextKey = "ContextKey." + dbContext.GetType().Name;
        }

        public IDbContext GetContext()
        {
            return _dbContext;

            //if (HttpContext.Current.Items[ContextKey] == null)
            //    HttpContext.Current.Items[ContextKey] = _dbContext.Clone();
            //return HttpContext.Current.Items[ContextKey] as IDbContext;
        }

        public void Finish()
        {
            if (HttpContext.Current.Items[ContextKey] != null)
                (HttpContext.Current.Items[ContextKey] as IDbContext).Dispose();
        }
    }
}
