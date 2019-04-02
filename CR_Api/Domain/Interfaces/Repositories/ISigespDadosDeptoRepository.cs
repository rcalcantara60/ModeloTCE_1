using Dto.API.Sigesp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ISigespDadosDeptoRepository
    {
        IEnumerable<LotacaoDto> obterListagemLotacoesAtivas();
        Task<IEnumerable<LotacaoDto>> obterListagemLotacoesAtivasAsync(CancellationToken cancellationToken);
    }

}
