using Application.Dto.Comum;
using System;

namespace Application.Dto
{
    public class ListaTREDto : EntityBaseDto
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public int Processo { get; set; }
        public DateTime DataSessao { get; set; }
        public string Decisao { get; set; }
        public DateTime? DataTransitoJulgado { get; set; }
        public string Municipio { get; set; }
        public int? NotaTaq { get; set; }
        public int? Acordao { get; set; }
        public int? ProcessoCNX { get; set; }
        public int? NotaTaqConexo { get; set; }
        public int? AcordaoConexo { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public ListaTREDto()
        {
        }
    }
}
