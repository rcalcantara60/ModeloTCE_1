using LinqToExcel.Attributes;
using FluentValidation;
using Domain.Entities.Comum;
using Domain.Validators;
using System;
using TCE.DomainLayerBase.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class RelatorioCorregedoria : EntityRegistroArquivo<RelatorioCorregedoria>
    {
        [ExcelColumn("Descrição")]
        public string Descricao { get; set; }

        [ExcelColumn("Mês do relatório (númerico)")]
        public int? Mes { get; set; }
        public bool Mensal { get; set; }

        [ExcelColumn("Trimestre do relatório (numerico)")]
        public int? Trimestre { get; set; }
        public bool Trimestral { get; set; }

        [ExcelColumn("Ano do relatório *")]
        public int Ano { get; set; }
        public bool Anual { get; set; }

        [ExcelColumn("Link do relatório *")]
        public string Url { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }        

        private string isMensal;
        [NotMapped]
        [ExcelColumn("Mensal (s ou n)")]
        public string IsMensal
        {
            get => isMensal;
            set
            {
                isMensal = value;
                Mensal = value == "s" ? true : false;
            }
        }

        private string isTrimestral;
        [NotMapped]
        [ExcelColumn("Trimestral (s ou n)")]
        public string IsTrimestral
        {
            get => isTrimestral;
            set
            {
                isTrimestral = value;
                Trimestral = value == "s" ? true : false;
            }
        }

        private string isAnual;
        [NotMapped]
        [ExcelColumn("Anual (s ou n)")]
        public string IsAnual
        {
            get => isAnual;
            set
            {
                isAnual = value;
                Anual = value == "s" ? true : false;            
            }
        }

        public RelatorioCorregedoria()
        {
            _validator = new RelatorioCorregedoriaValidator();
        }

        public override bool IsValidToAdd(IServiceBase<RelatorioCorregedoria> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultInsert");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToDelete(IServiceBase<RelatorioCorregedoria> service)
        {
            throw new System.NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<RelatorioCorregedoria> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultUpdate");
            return ValidationResult.IsValid;
        }
    }
}
