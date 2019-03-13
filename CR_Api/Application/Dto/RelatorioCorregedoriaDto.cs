using Application.Dto.Comum;
using System;

namespace Application.Dto
{
    public class RelatorioCorregedoriaDto : EntityBaseDto
    {
        public string Descricao { get; set; }
        public bool Mensal { get; set; }
        public int? Mes { get; set; }
        public bool Trimestral { get; set; }
        public int? Trimestre { get; set; }
        public bool Anual { get; set; }
        public int Ano { get; set; }
        public string Url { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public long IdArquivo { get; set; }

        public RelatorioCorregedoriaDto()
        {

        }
    }
}
