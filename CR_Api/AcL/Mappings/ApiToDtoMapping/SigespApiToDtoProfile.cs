using AcL.Sigesp.Dto;
using AutoMapper;
using Dto.API.Sigesp;

namespace AcL.Mappings.ApiToDtoMapping
{
    class SigespApiToDtoProfile: Profile
    {
        public SigespApiToDtoProfile()
        {
            CreateMap<LotacoesAtivasResponse, LotacaoDto>();
            CreateMap<PessoasAtivasResponse, PessoaDto>();
        }
    }
}
