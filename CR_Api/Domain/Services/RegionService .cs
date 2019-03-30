using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services.Comum;
using System;
using TCE.CrossCutting.Dto;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;

using System.Collections.Generic;
using System.Data.Entity;
using Domain.Interfaces.Repositories;
using FluentValidation;

namespace Domain.Services
{
    public class RegionService : ServiceBaseLocal<REGION>, IRegionService
    {
        public RegionService(IEFRepositoryBase<REGION> repositoryEf, IMicroORMBaseRepository<REGION> repositoryMicroOrm, IValidator<REGION> v) : base(repositoryEf, repositoryMicroOrm, v)
        {
            
        }

        public bool VerificaSeRegiaoExiste(decimal regionId)
        {
            return _repository.Count(r => r.REGION_ID == regionId) > 0;
        }        
    }
}
