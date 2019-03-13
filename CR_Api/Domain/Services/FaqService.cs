using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;
using System.Linq;

namespace Domain.Services
{
    public class FaqService : ServiceBase<Faq>, IFaqService
    {
        public FaqService(IEFRepositoryBase<Faq> repository) : base(repository)
        {
        }

        public IEnumerable<Faq> GetAll()
        {
            return _repository.All();
        }
    }
}
