using Domain.Entities.Comum;
using FluentValidation;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public partial class EMP_DETAILS_VIEW : EntityBaseLocal<EMP_DETAILS_VIEW>
    {
        public int EMPLOYEE_ID { get; set; }
        public string JOB_ID { get; set; }
        public Nullable<int> MANAGER_ID { get; set; }
        public Nullable<short> DEPARTMENT_ID { get; set; }
        public Nullable<short> LOCATION_ID { get; set; }
        public string COUNTRY_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public Nullable<decimal> SALARY { get; set; }
        public Nullable<decimal> COMMISSION_PCT { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string JOB_TITLE { get; set; }
        public string CITY { get; set; }
        public string STATE_PROVINCE { get; set; }
        public string COUNTRY_NAME { get; set; }
        public string REGION_NAME { get; set; }

        public override bool IsValidToAdd(IServiceBase<EMP_DETAILS_VIEW> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToDelete(IServiceBase<EMP_DETAILS_VIEW> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<EMP_DETAILS_VIEW> service)
        {
            throw new NotImplementedException();
        }

        public override void SetValidator(IValidator<EMP_DETAILS_VIEW> v)
        {
            throw new NotImplementedException();
        }
    }
}
