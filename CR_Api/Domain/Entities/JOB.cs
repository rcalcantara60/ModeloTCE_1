using Domain.Entities.Comum;
using FluentValidation;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public class JOB: EntityBaseLocal<JOB>
    {
        public JOB()
        {
            this.EMPLOYEES = new List<EMPLOYEE>();
            this.JOB_HISTORY = new List<JOB_HISTORY>();
        }

        public string JOB_ID { get; set; }
        public string JOB_TITLE { get; set; }
        public Nullable<int> MIN_SALARY { get; set; }
        public Nullable<int> MAX_SALARY { get; set; }
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

        public override void SetValidator(IValidator<JOB> v)
        {
            throw new NotImplementedException();
        }
    }
}
