using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloBack
{
    public class GitHubClient
    {
        private readonly HttpClient Client;

        public GitHubClient(HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.github.com/");

            // GitHub API versioning
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");

            // GitHub requires a user-agent
            client.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");

            Client = client;
        }

        public async Task<string> GetData()
        {
            var token = ReadToken();
            return "foo";
        }

        private async Task<string> ReadToken()
        {
            return await File.ReadAllTextAsync("token.txt");
        }
    }
}
