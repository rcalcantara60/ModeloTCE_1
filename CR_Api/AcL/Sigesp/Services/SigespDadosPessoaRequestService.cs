using AcL.Sigesp.Interfaces;
using Resources;
using TCE.RestClient;

namespace AcL.Sigesp.Services
{
    public class SigespDadosPessoaRequestService : BaseApiService, ISigespDadosPessoaRequestService
    {
        public SigespDadosPessoaRequestService(ServiceSettings serviceSettings):base(serviceSettings)
        {
            
        }
    }
}
