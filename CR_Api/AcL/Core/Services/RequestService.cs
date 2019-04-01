
using System.Threading;
using System.Threading.Tasks;
using AcL.Core.Interfaces;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System;
using System.Text;
using AcL.Core.Exceptions;
using AcL.Core.Extensions;

namespace AcL.Core.Services
{
    public class RequestService : IRequestService
    {
        private const string _mediaType = "application/json";
        public string UrlBase { get; private set; }
        public HttpClient HttpClient { get; private set; }
        private HttpResponseHeaders _responseHeader;

        public RequestService()
        {
            HttpClient = new HttpClient();
        }

        public RequestService(string urlBase)
                : this()
        {
            UrlBase = urlBase;
            HttpClient.BaseAddress = new System.Uri(UrlBase);
        }

        public void AddHeader(string key, string value) => HttpClient.DefaultRequestHeaders.Add(key, value);

        private static string GetData<TRequest>(TRequest request) => JsonConvert.SerializeObject(request);

        public string GetHeaderResponse(string key)
        {
            var header = _responseHeader.FirstOrDefault(f => f.Key == key);
            return header.Value.First();
        }

        private async Task<TResponse> ResponseAsync<TResponse>(HttpResponseMessage result)
        {
            var resultContent = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
            {
                _responseHeader = result.Headers;
                var response = JsonConvert.DeserializeObject<TResponse>(resultContent);
                //_logger.Info("request-response", resultContent);
                // _logger.Info(resultContent);
                return response;
            }
            else if (result.StatusCode == HttpStatusCode.BadRequest)
                throw new BadRequestException(resultContent);

            throw new Exception(resultContent);
        }

        public string GetUrl(string action)
        {
            return $"{UrlBase}{action}";
        }

        public Uri GetUrl<TRequest>(string action, TRequest request)
        {
            var url = GetUrl(action);
            return url.ToUri(request);
        }

        public virtual async Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken)
        {
            return await PostAsync<TRequest, TResponse>(request, string.Empty, cancellationToken);
        }

        public virtual async Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, string action, CancellationToken cancellationToken)
        {
            var json = GetData(request);
            //_logger.Info(json);
            var content = new StringContent(json, Encoding.UTF8, _mediaType);

            var url = GetUrl(action);
            var result = await HttpClient.PostAsync(url, content, cancellationToken);
            return await ResponseAsync<TResponse>(result);
        }

        public virtual async Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken)
        {
            return await GetAsync<TRequest, TResponse>(request, string.Empty, cancellationToken);
        }

        public virtual async Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request, string action, CancellationToken cancellationToken)
        {
            var url = GetUrl(action, request);
            //_logger.Info("request-url");
            //_logger.Info(url);
            var result = await HttpClient.GetAsync(url, cancellationToken);
            return await ResponseAsync<TResponse>(result);
        }

        public virtual async Task<TResponse> GetAsync<TResponse>(CancellationToken cancellationToken)
        {
            return await GetAsync<TResponse>(string.Empty, cancellationToken);
        }

        public virtual async Task<TResponse> GetAsync<TResponse>(string action, CancellationToken cancellationToken)
        {
            var url = GetUrl(action);
            var result = await HttpClient.GetAsync(url, cancellationToken);
            return await ResponseAsync<TResponse>(result);
        }

        public virtual async Task<TResponse> PutAsync<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken)
        {
            return await PutAsync<TRequest, TResponse>(request, string.Empty, cancellationToken);
        }

        public virtual async Task<TResponse> PutAsync<TRequest, TResponse>(TRequest request, string action, CancellationToken cancellationToken)
        {
            var json = GetData(request);
            var content = new StringContent(json, Encoding.UTF8);
            var url = GetUrl(action);

            var result = await HttpClient.PutAsync(url, content, cancellationToken);
            return await ResponseAsync<TResponse>(result);
        }

        public virtual async Task DeleteAsync<TRequest>(TRequest request, CancellationToken cancellationToken)
        {
            await DeleteAsync(request, string.Empty, cancellationToken);
        }

        public virtual async Task DeleteAsync<TRequest>(TRequest request, string action, CancellationToken cancellationToken)
        {
            var json = GetData(request);

            using (var content = new StringContent(json, Encoding.UTF8, _mediaType))
            {
                var url = GetUrl(action);
                var result = await HttpClient.DeleteAsync(url, cancellationToken);

                var resultContent = await result.Content.ReadAsStringAsync();
                if (!result.IsSuccessStatusCode)
                    throw new BadRequestException(resultContent);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                HttpClient.Dispose();
                UrlBase = string.Empty;
                _responseHeader = null;
            }
        }
    }
}
