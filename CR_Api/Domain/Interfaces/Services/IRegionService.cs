using Domain.Entities;
using Domain.Interfaces.Services.Comum;
using System.Collections.Generic;
using TCE.CrossCutting.Dto;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface IRegionService : IServiceBaseLocal<REGION>
    {
        bool VerificaSeRegiaoExiste(decimal regionId);
    }
}