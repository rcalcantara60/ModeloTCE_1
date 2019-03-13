using Application.Dto.Comum;
using System;

namespace Application.Dto
{
    public class ConcursoDto : EntityBaseDto
    {
        public int Numero { get; set; }
        public int Ano { get; set; }
        public string Titulo { get; set; }
        public string Objeto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public DateTime? DataDivulgacao { get; set; }
        public string Url { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public ConcursoDto()
        {

        }
    }
}
