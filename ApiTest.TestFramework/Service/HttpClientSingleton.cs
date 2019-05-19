using ApiTest.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.TestFramework.Service
{
    public static class HttpClientSingleton
    {
        #region Private Fields

        private static HttpClient _client = new HttpClient();

        #endregion

        #region Public Methods

        public static async Task GetData(ITestInput testInput)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(CreateUrl(testInput)),
                Method = testInput.HttpMethod
            };
            foreach (var header in testInput.Headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }
        }

        #endregion

        #region Private Methods

        private static string CreateUrl(ITestInput testInput)
        {
            var url = testInput.BaseUrl;
            foreach (var param in testInput.Parameters)
            {
                url = url.Replace(param.Key, param.Value);
            }
            url += CreateQueryString(testInput.QueryParameters);
            return url;
        }

        private static string CreateQueryString(Dictionary<string, string> queries)
        {
            var queryString = "?";
            var count = 0;
            foreach (var query in queries)
            {
                queryString += 0 != queries.Count - 1 ? $"{query.Key}={query.Value}&" : $"{query.Key}={query.Value}";
                count++;
            }
            return queryString;
        }

        #endregion
    }
}
