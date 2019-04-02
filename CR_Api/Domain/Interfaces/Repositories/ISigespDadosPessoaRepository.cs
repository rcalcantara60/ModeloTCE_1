

using Dto.API.Sigesp;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ISigespDadosPessoaRepository
    {
        IEnumerable<PessoaDto> ConsultarPessoasAtivasPorNome(string nome);
        Task<IEnumerable<PessoaDto>> ConsultaPessoasAtivasPorNomeAsync(string nome, CancellationToken cancellationToken);
    }
}
