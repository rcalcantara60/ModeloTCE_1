using Domain.Entities.Comum;
using FluentValidation;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public partial class REGION: EntityBaseLocal<REGION>
    {
        public REGION()
        {
            this.COUNTRIES = new List<COUNTRy>();
        }

        public decimal REGION_ID { get; set; }
        public string REGION_NAME { get; set; }
        public virtual ICollection<COUNTRy> COUNTRIES { get; set; }

        public override bool IsValidToAdd()
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToDelete()
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade()
        {
            throw new NotImplementedException();
        }

        public override void SetValidator(IValidator<REGION> v)
        {
            throw new NotImplementedException();
        }
    }
}
