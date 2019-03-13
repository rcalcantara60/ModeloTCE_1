using Domain.Interfaces.Services.Comum;
using System;
using TCE.DomainLayerBase.Validator;

namespace Domain.Validators.Comum
{
    public abstract class BaseValidatorLocal<T> : BaseValidator<T> where T : class
    {
        protected bool LessThanOrEqualToMaxDecimal(decimal? valor)
        {
            if (valor != null)
                return valor <= 99999999999999.99m;
            return true;
        }
        protected bool VerificaDataInicialFinal(DateTime dataInicial, DateTime? dataFinal)
        {
            if (dataFinal != null)
                return dataFinal.Value.Date >= dataInicial.Date;
            return true;
        }
    }
}
