using LinqToExcel.Attributes;
using FluentValidation;
using Domain.Entities.Comum;
using Domain.Validators;
using System;
using TCE.DomainLayerBase.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Sancao : EntityRegistroArquivo<Sancao>
    {
        [ExcelColumn("Ano Decisão")]
        public int anoRefProcesso { get; set; }
        [ExcelColumn("Ano Trânsito em Julgado")]
        public int? anoTransito { get; set; }
        [ExcelColumn("Município")]
        public string municipioProcesso { get; set; }
        [ExcelColumn("Nome")]
        public string nomeDevedor { get; set; }
        
        public string numCpfCgcPte { get; set; }
        [ExcelColumn("Irregularidade")]
        public string Irregularidade { get; set; }
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
                numCpfCgcPte = value.Replace("-","").Replace(".", "").Replace(".", "").Replace("/", "");
            }
        }

        public Sancao()
        {
            _validator = new SancaoValidator();
        }

        public override bool IsValidToAdd(IServiceBase<Sancao> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultInsert");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToDelete(IServiceBase<Sancao> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<Sancao> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultUpdate");
            return ValidationResult.IsValid;
        }
    }
}
