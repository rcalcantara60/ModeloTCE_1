using Domain.Entities;
using Domain.Validators.Validations;
using FluentValidation;
using TCE.DomainLayerBase.Validator;

namespace Domain.Validators
{
    public class FaqValidator : BaseValidator<Faq>
    {
        public FaqValidator()
        {
            SetValidators();
        }

        public override void SetCommonValidators()
        {
            RuleFor(enity => enity.Pergunta).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
            RuleFor(enity => enity.Resposta).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
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
