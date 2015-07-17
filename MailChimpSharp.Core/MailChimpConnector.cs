using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using RestSharp;

namespace MailChimpSharp.Core
{
    internal class MailChimpConnector : IMailChimpConnector
    {
        private const string InvalidApiKeyMessage = "API key is not valid. Must be a valid v2.0 Mailchimp API key";
        private string _accessToken;
        private string _dataCentrePrefix;

        public MailChimpConnector(string apiKey)
        {
            ParseApiKey(apiKey);
        }

        public MailChimpConnector(string accessToken, string dataCentrePrefix)
        {
            _accessToken = accessToken;
            _dataCentrePrefix = dataCentrePrefix;
        }

        public TResult Execute<TResult>(string action, object args) where TResult : new()
        {
            if (string.IsNullOrWhiteSpace(_accessToken) || string.IsNullOrWhiteSpace(_dataCentrePrefix))
            {
                throw new ArgumentException(InvalidApiKeyMessage);
            }

            var client = CreateClient();
            var request = CreateRequest(action, args);

            var response = client.Execute<TResult>(request);

            if (response.ErrorException != null)
            {
                HandleError(response);
            }

            return response.Data;
        }

        public async Task<TResult> ExecuteAsync<TResult>(string action, object args) where TResult : new()
        {
            if (string.IsNullOrWhiteSpace(_accessToken) || string.IsNullOrWhiteSpace(_dataCentrePrefix))
            {
                throw new ArgumentException(InvalidApiKeyMessage);
            }

            var client = CreateClient();
            var request = CreateRequest(action, args);

            // todo: add retry logic (Polly)
            var response = await client.ExecuteTaskAsync<TResult>(request);

            if (response.ErrorException != null)
            {
                await HandleErrorAsync(response);
            }

            return response.Data;
        }

        private static IRestRequest CreateRequest(string action, object args)
        {
            var request = new RestRequest(action, Method.POST)
                .AddJsonBody(args);

            request.RequestFormat = DataFormat.Json;

            // todo: Get this from configuration
            request.Timeout = (int)TimeSpan.FromSeconds(100).TotalMilliseconds;
            request.ReadWriteTimeout = (int)TimeSpan.FromSeconds(100).TotalMilliseconds;
            return request;
        }

        private static void HandleError(IRestResponse response)
        {
            var errorResponse = HandleErrorImpl(response);

            if (errorResponse == null)
            {
                throw response.ErrorException;
            }

            using (var reader = new StreamReader(errorResponse.GetResponseStream()))
            {
                var errorResponseContent = reader.ReadToEnd();

                // todo: deserialize into an api error object
            }
        }

        private static async Task HandleErrorAsync(IRestResponse response)
        {
            var errorResponse = HandleErrorImpl(response);

            if (errorResponse == null)
            {
                throw response.ErrorException;
            }

            using (var reader = new StreamReader(errorResponse.GetResponseStream()))
            {
                var errorResponseContent = await reader.ReadToEndAsync();

                // todo: deserialize into an api error object
            }
        }

        private static HttpWebResponse HandleErrorImpl(IRestResponse response)
        {
            var webException = response.ErrorException as WebException;
            if (webException == null)
            {
                throw response.ErrorException;
            }

            return webException.Response as HttpWebResponse;
        }

        private RestClient CreateClient()
        {
            return new RestClient(string.Format("https://{0}.api.mailchimp.com/2.0/", _dataCentrePrefix));
        }

        private void ParseApiKey(string apiKey)
        {
            var strings = apiKey.Split('-');
            if (strings.Length != 2)
            {
                throw new ArgumentException(InvalidApiKeyMessage);
            }

            _accessToken = strings[0];
            _dataCentrePrefix = strings[1];
        }
    }
}