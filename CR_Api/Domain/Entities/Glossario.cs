using LinqToExcel.Attributes;
using FluentValidation;
using Domain.Entities.Comum;
using Domain.Validators;
using System;
using TCE.DomainLayerBase.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Glossario : EntityRegistroArquivo<Glossario>
    {
        [ExcelColumn("Contexto")]
        public string Palavra { get; set; }
        [ExcelColumn("Descrição")]
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public Glossario()
        {
            _validator = new GlossarioValidator();
        }

        public override bool IsValidToAdd(IServiceBase<Glossario> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultInsert");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToDelete(IServiceBase<Glossario> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<Glossario> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultUpdate");
            return ValidationResult.IsValid;
        }
    }
}
