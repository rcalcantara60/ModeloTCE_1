using Domain.Entities;
using Domain.Validators.Validations;
using FluentValidation;
using TCE.DomainLayerBase.Validator;

namespace Domain.Validators
{
    public class GlossarioValidator : BaseValidator<Glossario>
    {
        public GlossarioValidator()
        {
            SetValidators();
        }

        public override void SetCommonValidators()
        {
            RuleFor(enity => enity.Descricao).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
            RuleFor(enity => enity.Palavra).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
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
