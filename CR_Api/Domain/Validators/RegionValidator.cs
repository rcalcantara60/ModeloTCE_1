using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services;
using Domain.Validators.Comum;
using Domain.Validators.Validations;
using FluentValidation;
using TCE.Repository.Interfaces;

namespace Domain.Validators
{
    public class RegionValidator : BaseValidatorLocal<REGION>
    {        
        public RegionValidator(IEFRepositoryBase<REGION> repositoryBase) : base(repositoryBase)
        {     
            SetValidators();
        }

        public override void SetCommonValidators()
        {
            //RuleFor(enity => enity.COUNTRY_ID).NotEmpty().WithMessage(ValidationMessages.NaoNuloInsert);
            //RuleFor(enity => enity.REGION_ID).Must(id => RegiaoExiste(id.Value)).WithMessage(ValidationMessages.RegionIDDeveExistir);
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

        /*public bool RegiaoExiste(decimal regionId)
        {
            return _regionService.VerificaSeRegiaoExiste(regionId);
        }*/
    }
}
