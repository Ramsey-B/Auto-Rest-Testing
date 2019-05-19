using ApiTest.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ApiTest.DAO.Data
{
    public class TestInput : ITestInput
    {
        public string BaseUrl { get; set; }
        public string UrlPath { get; set; }
        public HttpMethod HttpMethod { get; set; }
        public Encoding Encoding { get; set; }
        public string ContentType { get; set; }
        public HttpRequestHeader Headers { get; set; }
        public object RequestBody { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Dictionary<string, string> QueryParameters { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }
}
