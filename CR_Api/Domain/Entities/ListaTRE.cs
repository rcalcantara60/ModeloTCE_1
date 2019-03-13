using LinqToExcel.Attributes;
using FluentValidation;
using Domain.Entities.Comum;
using Domain.Validators;
using System;
using TCE.DomainLayerBase.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ListaTRE : EntityRegistroArquivo<ListaTRE>
    {
        public string Cpf { get; set; }
        [ExcelColumn("Nome")]
        public string Nome { get; set; }
        [ExcelColumn("Número do Processo")]
        public int Processo { get; set; }
        [ExcelColumn("Data Sessão TCE")]
        public DateTime DataSessao { get; set; }
        [ExcelColumn("Decisão TCEMG")]
        public string Decisao { get; set; }
        [ExcelColumn("Data Transito em Julgado")]
        public DateTime? DataTransitoJulgado { get; set; }
        [ExcelColumn("Município")]
        public string Municipio { get; set; }
        [ExcelColumn("Nota Taq.")]
        public int? NotaTaq { get; set; }
        [ExcelColumn("Acórdão")]
        public int? Acordao { get; set; }
        [ExcelColumn("Processo CNX")]
        public int? ProcessoCNX { get; set; }
        [ExcelColumn("Nota Taq. Conexo")]
        public int? NotaTaqConexo { get; set; }
        [ExcelColumn("Acórdão Conexo")]
        public int? AcordaoConexo { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        private string isCPF;
        [NotMapped]
        [ExcelColumn("CPF")]
        public string IsCPF
        {
            get => isCPF;
            set
            {
                isCPF = value;
                Cpf = value != null ? value.Replace("-", "").Replace(".", "").Replace(".", "").Replace("/", "") : "";
            }
        }

        public ListaTRE()
        {
            _validator = new ListaTREValidator();
        }

        public override bool IsValidToAdd(IServiceBase<ListaTRE> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultInsert");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToDelete(IServiceBase<ListaTRE> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<ListaTRE> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultUpdate");
            return ValidationResult.IsValid;
        }
    }
}
