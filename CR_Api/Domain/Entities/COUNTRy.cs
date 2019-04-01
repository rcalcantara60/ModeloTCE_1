using Domain.Entities.Comum;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using FluentValidation;
using Domain.Validators;

namespace Domain.Entities
{
    public class COUNTRy : EntityBaseLocal<COUNTRy>
    {
        public COUNTRy()
        {
            this.LOCATIONS = new List<LOCATION>();            
        }

        public string COUNTRY_ID { get; set; }
        public string COUNTRY_NAME { get; set; }
        public Nullable<decimal> REGION_ID { get; set; }
        public virtual REGION REGION { get; set; }
        public virtual ICollection<LOCATION> LOCATIONS { get; set; }

        public override bool IsValidToAdd()
        {
            //EntityBaseLocal<COUNTRy>.Validate(this);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultInsert");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToDelete()
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade()
        {
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultUpdate");
            return ValidationResult.IsValid;
        }

        public override void SetValidator(IValidator<COUNTRy> v)
        {
            _validator = (CountryValidator)v;
        }
    }
}
