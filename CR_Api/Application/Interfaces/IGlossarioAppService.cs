using Application.Dto;
using Application.Views;
using System.Collections.Generic;
using TCE.AppLayerBase.Base;

namespace Application.Interfaces
{
    public interface IGlossarioAppService : IAppServiceBase<GlossarioDto>
    {
        IEnumerable<GlossarioDto> GetAll();
        IEnumerable<GloassarioAgrupadoDto> GetAllAgrupado();
    }
}
