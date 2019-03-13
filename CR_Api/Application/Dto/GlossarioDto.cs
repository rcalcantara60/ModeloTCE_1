using Application.Dto.Comum;
using System;

namespace Application.Dto
{
    public class GlossarioDto : EntityBaseDto
    {
        public string Palavra { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public GlossarioDto()
        {

        }
    }
}
