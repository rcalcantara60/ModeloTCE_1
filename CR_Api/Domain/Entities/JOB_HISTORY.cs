using Domain.Entities.Comum;
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

        public override bool IsValidToAdd(IServiceBase<JOB_HISTORY> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToDelete(IServiceBase<JOB_HISTORY> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<JOB_HISTORY> service)
        {
            throw new NotImplementedException();
        }
    }
}
