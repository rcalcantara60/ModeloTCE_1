using Domain.Entities;
using Domain.Validators.Validations;
using FluentValidation;
using TCE.DomainLayerBase.Validator;

namespace Domain.Validators
{
    public class SancaoValidator : BaseValidator<Sancao>
    {
        public SancaoValidator()
        {
            SetValidators();
        }

        public override void SetCommonValidators()
        {
            RuleFor(enity => enity.anoRefProcesso).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
            RuleFor(enity => enity.nomeDevedor).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
            RuleFor(enity => enity.municipioProcesso).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
            RuleFor(enity => enity.Irregularidade).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
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
