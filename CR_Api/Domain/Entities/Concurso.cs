﻿using LinqToExcel.Attributes;
using FluentValidation;
using Domain.Entities.Comum;
using Domain.Validators;
using System;
using TCE.DomainLayerBase.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Concurso : EntityRegistroArquivo<Concurso>
    {
        [ExcelColumn("Número do Edital")]
        public int Numero { get; set; }
        [ExcelColumn("Ano do Edital")]
        public int Ano { get; set; }
        [ExcelColumn("Título")]
        public string Titulo { get; set; }
        [ExcelColumn("Objeto")]
        public string Objeto { get; set; }
        [ExcelColumn("Data de inicio do processo")]
        public DateTime DataInicio { get; set; }
        [ExcelColumn("Data de fim do processo")]
        public DateTime? DataFim { get; set; }
        [ExcelColumn("Data de divulgação do resultado")]
        public DateTime? DataDivulgacao { get; set; }
        [ExcelColumn("Link da página do Edital")]
        public string Url { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public Concurso()
        {
            _validator = new ConcursoValidator();
        }

        public override bool IsValidToAdd(IServiceBase<Concurso> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultInsert");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToDelete(IServiceBase<Concurso> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<Concurso> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultUpdate");
            return ValidationResult.IsValid;
        }
    }
}
