using Domain.Entities.Comum;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using FluentValidation;

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

        public override bool IsValidToAdd(IServiceBase<COUNTRy> service)
        {
            _validator.SetService(service);
            ValidationResult = _validator.Validate(this, ruleSet: "DefaultInsert");
            return ValidationResult.IsValid;
        }

        public override bool IsValidToDelete(IServiceBase<COUNTRy> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<COUNTRy> service)
        {
            throw new NotImplementedException();
        }
    }
}
