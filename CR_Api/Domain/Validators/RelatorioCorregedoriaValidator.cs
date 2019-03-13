using Domain.Entities;
using Domain.Validators.Validations;
using FluentValidation;
using TCE.DomainLayerBase.Validator;

namespace Domain.Validators
{
    public class RelatorioCorregedoriaValidator : BaseValidator<RelatorioCorregedoria>
    {
        public RelatorioCorregedoriaValidator()
        {
            SetValidators();
        }

        public override void SetCommonValidators()
        {
            RuleFor(enity => enity.Url).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
        }

        public override void SetValidators()
        {
            RuleSet("DefaultInsert", () =>
            {
                SetCommonValidators();
            });
            RuleSet("DefaultUpdate", () =>
            {
                RuleFor(enity => enity.Id).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
                SetCommonValidators();
            });
        }
    }
}
