using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.API.Sigesp
{
    public class PessoaDto
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Lotacao { get; set; }
        public string IdLotacao { get; set; }
    }
}
