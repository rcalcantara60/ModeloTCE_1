using FluentValidation;
using Domain.Entities.Comum;
using Domain.Validators;
using System;
using TCE.DomainLayerBase.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Arquivo : EntityBaseLocal<Arquivo>
    {
        public long IdCategoria { get; set; }
        public virtual Indicador Categoria { get; set; }

        public long IdSituacao { get; set; }
        public virtual Indicador Situacao { get; set; }

        public long IdStatus { get; set; }
        public virtual Indicador Status { get; set; }

        public byte[] ByArquivo { get; set; }
        public string Extensao { get; set; }
        public string MimeType { get; set; }
        public long IdPessoa { get; set; }
        public DateTime DataCadastro { get; set; }

        public Arquivo()
        {
            _validator = new ArquivoValidator();
        }

        public override bool IsValidToAdd(IServiceBase<Arquivo> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultInsert");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToUpdade(IServiceBase<Arquivo> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultUpdate");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToDelete(IServiceBase<Arquivo> service)
        {
            throw new System.NotImplementedException();
        }
    }
}
