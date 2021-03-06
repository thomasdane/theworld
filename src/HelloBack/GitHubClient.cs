﻿using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HelloBack
{
    public class GitHubClient
    {
        private readonly HttpClient Client;

        public GitHubClient(HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.github.com/");
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            client.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-Sample");
  
            Client = client;
        }

        public async Task<HttpResponseMessage> GetData()
        {
            var token = await ReadToken();
            Client.DefaultRequestHeaders.Authorization= new AuthenticationHeaderValue("token", token);
            var url = "/search/code?q=helloworld";
            return await Client.GetAsync(url);
        }

        private async Task<string> ReadToken()
        {
            return await File.ReadAllTextAsync("token.txt");
        }
    }
}
