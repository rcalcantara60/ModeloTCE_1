using Domain.Entities.Comum;
using FluentValidation;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public partial class EMPLOYEE: EntityBaseLocal<EMPLOYEE>
    {
        public EMPLOYEE()
        {
            this.DEPARTMENTS = new List<DEPARTMENT>();
            this.EMPLOYEES1 = new List<EMPLOYEE>();
            this.JOB_HISTORY = new List<JOB_HISTORY>();
        }

        public int EMPLOYEE_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NUMBER { get; set; }
        public System.DateTime HIRE_DATE { get; set; }
        public string JOB_ID { get; set; }
        public Nullable<decimal> SALARY { get; set; }
        public Nullable<decimal> COMMISSION_PCT { get; set; }
        public Nullable<int> MANAGER_ID { get; set; }
        public Nullable<short> DEPARTMENT_ID { get; set; }
        public virtual ICollection<DEPARTMENT> DEPARTMENTS { get; set; }
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual JOB JOB { get; set; }
        public virtual ICollection<EMPLOYEE> EMPLOYEES1 { get; set; }
        public virtual EMPLOYEE EMPLOYEE1 { get; set; }
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

        public override void SetValidator(IValidator<EMPLOYEE> v)
        {
            throw new NotImplementedException();
        }
    }
}
