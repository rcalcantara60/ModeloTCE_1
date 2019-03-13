using Application.Dto;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;

namespace Application.Interfaces
{
    public interface IFaqAppService : IAppServiceBase<FaqDto>
    {
        IEnumerable<FaqDto> GetAll();
    }
}
