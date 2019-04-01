using Domain.Entities.Comum;
using FluentValidation;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public class DEPARTMENT: EntityBaseLocal<DEPARTMENT>
    {
        public DEPARTMENT()
        {
            this.EMPLOYEES = new List<EMPLOYEE>();
            this.JOB_HISTORY = new List<JOB_HISTORY>();
        }

        public short DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public Nullable<int> MANAGER_ID { get; set; }
        public Nullable<short> LOCATION_ID { get; set; }
        public virtual LOCATION LOCATION { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        public virtual ICollection<EMPLOYEE> EMPLOYEES { get; set; }
        public virtual ICollection<JOB_HISTORY> JOB_HISTORY { get; set; }

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

        public override void SetValidator(IValidator<DEPARTMENT> v)
        {
            throw new NotImplementedException();
        }
    }
}
