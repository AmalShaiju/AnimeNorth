using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AnimeNorth.Data
{
    public static class Kitsu
    {
        internal const string BaseUri = "https://kitsu.io/api/edge";
        private static HttpClient RequestClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.api+json"));
            return client;
        }

        internal static readonly HttpClient Client = RequestClient();
    }
}
