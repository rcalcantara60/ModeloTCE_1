using Domain.Entities.Comum;
using FluentValidation;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public partial class LOCATION: EntityBaseLocal<LOCATION>
    {
        public LOCATION()
        {
            this.DEPARTMENTS = new List<DEPARTMENT>();
        }

        public short LOCATION_ID { get; set; }
        public string STREET_ADDRESS { get; set; }
        public string POSTAL_CODE { get; set; }
        public string CITY { get; set; }
        public string STATE_PROVINCE { get; set; }
        public string COUNTRY_ID { get; set; }
        public virtual COUNTRy COUNTRy { get; set; }
        public virtual ICollection<DEPARTMENT> DEPARTMENTS { get; set; }

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

        public override void SetValidator(IValidator<LOCATION> v)
        {
            throw new NotImplementedException();
        }
    }
}
