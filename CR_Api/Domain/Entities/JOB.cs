using Domain.Entities.Comum;
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

        public override bool IsValidToAdd(IServiceBase<JOB> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToDelete(IServiceBase<JOB> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<JOB> service)
        {
            throw new NotImplementedException();
        }
    }
}
