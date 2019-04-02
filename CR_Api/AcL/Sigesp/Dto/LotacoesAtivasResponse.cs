using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcL.Sigesp.Dto
{
    public class LotacoesAtivasResponse
    {
        public string IdSuperior { get; set; }
        public string NomeSuperior { get; set; }
        public string IdLotacao { get; set; }
        public string Nome { get; set; }
        public string DataCriacao { get; set; }
        public string Extinta { get; set; }
    }
}
