using AcL.Sigesp.Interfaces;
using Resources;
using TCE.RestClient;

namespace AcL.Sigesp.Services
{
    public class SigespAuthRequestService: BaseApiService, ISigespAuthRequestService
    {
        public SigespAuthRequestService(ServiceSettings serviceSettings):base(serviceSettings)
        {

        }
    }
}
