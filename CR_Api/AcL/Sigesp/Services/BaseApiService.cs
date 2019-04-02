
using Resources;
using TCE.RestClient;

namespace AcL.Sigesp.Services
{
    public class BaseApiService : RestClient
    {
        public BaseApiService(ServiceSettings serviceSettings) : base(serviceSettings.SigespDadosApi)
        {
            base.AddHeader("Authorization", serviceSettings.BearerToken);
        }
    }
}
