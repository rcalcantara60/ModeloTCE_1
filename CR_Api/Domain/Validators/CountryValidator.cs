using Domain.Entities;
using Domain.Validators.Comum;
using Domain.Validators.Validations;
using FluentValidation;

namespace Domain.Validators
{
    public class CountryValidator : BaseValidatorLocal<COUNTRy>
    {
        public CountryValidator()
        {
            SetValidators();
        }

        public override void SetCommonValidators()
        {
            //RuleFor(enity => enity.ByArquivo).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
            ////RuleFor(enity => enity.IdCategoria).Must(IdCategoria => IndicadorExiste(IdCategoria)).WithMessage("Categoria inválida.");
            ////RuleFor(enity => enity.IdSituacao).Must(IdSituacao => IndicadorExiste(IdSituacao)).WithMessage("Situação inválida.");
            ////RuleFor(enity => enity.IdStatus).Must(IdStatus => IndicadorExiste(IdStatus)).WithMessage("Status inválido.");
            //RuleFor(enity => enity.Extensao).MaximumLength(5).WithMessage(ValidationMessages.TamanhoMaximo);
            //RuleFor(enity => enity.MimeType).NotEmpty().MaximumLength(100).WithMessage(ValidationMessages.TamanhoMaximo);
        }

        public override void SetValidators()
        {
            RuleSet("DefaultInsert", () =>
            {
                SetCommonValidators();
            });
            RuleSet("DefaultUpdate", () =>
            {
                //RuleFor(enity => enity.Id).NotEmpty().WithMessage(ValidationMessages.NaoNuloEdit);
                SetCommonValidators();
            });
        }
    }
}
