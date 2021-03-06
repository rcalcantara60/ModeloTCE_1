using Domain.Entities.Comum;
using FluentValidation;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public partial class JOB_HISTORY: EntityBaseLocal<JOB_HISTORY>
    {
        public int EMPLOYEE_ID { get; set; }
        public System.DateTime START_DATE { get; set; }
        public System.DateTime END_DATE { get; set; }
        public string JOB_ID { get; set; }
        public Nullable<short> DEPARTMENT_ID { get; set; }
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        public virtual JOB JOB { get; set; }

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

        public override void SetValidator(IValidator<JOB_HISTORY> v)
        {
            throw new NotImplementedException();
        }
    }
}
