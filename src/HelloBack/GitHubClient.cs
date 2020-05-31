using System.Net.Http;

namespace HelloBack
{
    public class GitHubClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GitHubClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public string GetData()
        {
            var httpClient = _httpClientFactory.CreateClient();

            return foo;
        }
    }
}
