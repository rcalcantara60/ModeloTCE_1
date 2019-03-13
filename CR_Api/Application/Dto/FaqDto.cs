using Application.Dto.Comum;
using System;

namespace Application.Dto
{
    public class FaqDto : EntityBaseDto
    {
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public FaqDto()
        {

        }
    }
}
