using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ApiTest.DAO.Interfaces
{
    public interface ITestInput
    {
        string BaseUrl { get; set; }
        string ContentType { get; set; }
        Encoding Encoding { get; set; }
        Dictionary<string, string> Headers { get; set; }
        HttpMethod HttpMethod { get; set; }
        Dictionary<string, string> Parameters { get; set; }
        Dictionary<string, object> Properties { get; set; }
        Dictionary<string, string> QueryParameters { get; set; }
        object RequestBody { get; set; }
        string UrlPath { get; set; }
    }
}