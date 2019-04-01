using System;
using System.Threading;
using System.Threading.Tasks;

namespace AcL.Core.Interfaces
{
    public interface IRequestService : IDisposable
    {
        void AddHeader(string chave, string valor);
        string GetHeaderResponse(string key);
        Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken);
        Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, string action, CancellationToken cancellationToken);
        Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken);
        Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request, string action, CancellationToken cancellationToken);
        Task<TResponse> GetAsync<TResponse>(CancellationToken cancellationToken);
        Task<TResponse> GetAsync<TResponse>(string action, CancellationToken cancellationToken);
        Task<TResponse> PutAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken);
        Task<TResponse> PutAsync<TRequest, TResponse>(TRequest request, string action, CancellationToken cancellationToken);
        Task DeleteAsync<TRequest>(TRequest request, CancellationToken cancellationToken);
        Task DeleteAsync<TRequest>(TRequest request, string action, CancellationToken cancellationToken);
    }
}
