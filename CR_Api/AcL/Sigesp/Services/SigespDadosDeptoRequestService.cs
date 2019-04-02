using AcL.Sigesp.Interfaces;
using Resources;
using TCE.RestClient;

namespace AcL.Sigesp.Services
{
    public class SigespDadosDeptoRequestService : BaseApiService, ISigespDadosDeptoRequestService
    {
        public SigespDadosDeptoRequestService(ServiceSettings serviceSettings):base(serviceSettings)
        {

        }
    }
}
