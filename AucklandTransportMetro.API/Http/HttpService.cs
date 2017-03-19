using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AucklandTransportMetro.Http
{
    public abstract class HttpService
    {
        private const string _azureSubscriptionHeader = "Ocp-Apim-Subscription-Key";
        private readonly Uri _baseUri;

        protected HttpService(Uri baseUri)
        {
            if (baseUri?.IsAbsoluteUri ?? false)
            {
                throw new ArgumentException("Base request url must be an absolute URI.", nameof(baseUri));
            }

            _baseUri = baseUri;
        }

        public string SubscriptionKey { get; set; }

        protected virtual HttpClient CreateHttpClient()
        {
            var client = new HttpClient();

            if (!String.IsNullOrWhiteSpace(SubscriptionKey))
            {
                client.DefaultRequestHeaders.Add(_azureSubscriptionHeader, SubscriptionKey);
            }

            return client;
        }

        protected async Task<IEnumerable<TReturn>> GetAsync<TReturn>(Uri relativeUri) where TReturn : class
        {
            var requestUri = new Uri(_baseUri, relativeUri);

            HttpResponse<TReturn> response;

            using (var client = CreateHttpClient())
            {
                var jsonResponse = await client.GetStringAsync(requestUri);

                response = JsonConvert.DeserializeObject<HttpResponse<TReturn>>(jsonResponse);
            }

            return response.Response;
        }
    }
}