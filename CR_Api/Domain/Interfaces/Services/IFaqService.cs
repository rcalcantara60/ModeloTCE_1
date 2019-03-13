using Domain.Entities;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface IFaqService : IServiceBase<Faq>
    {
        IEnumerable<Faq> GetAll();
    }
}
