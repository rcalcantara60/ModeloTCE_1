using Domain.Entities;
using Domain.Validators.Validations;
using FluentValidation;
using TCE.DomainLayerBase.Validator;

namespace Domain.Validators
{
    public class ProcessoSeletivoValidator : BaseValidator<ProcessoSeletivo>
    {
        public ProcessoSeletivoValidator()
        {
            SetValidators();
        }

        public override void SetCommonValidators()
        {
            RuleFor(enity => enity.Numero).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
            RuleFor(enity => enity.Objeto).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
            RuleFor(enity => enity.Ano).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
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
