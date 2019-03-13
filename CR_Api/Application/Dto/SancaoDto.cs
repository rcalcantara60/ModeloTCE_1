using Application.Dto.Comum;
using System;

namespace Application.Dto
{
    public class SancaoDto : EntityBaseDto
    {
        public int anoRefProcesso { get; set; }
        public string municipioProcesso { get; set; }
        public string nomeDevedor { get; set; }
        public string numCpfCgcPte { get; set; }
        public string Irregularidade { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public SancaoDto()
        {

        }
    }
}
