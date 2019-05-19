using System.Net;

namespace ApiTest.DAO.Interfaces
{
    public interface ITestOutput
    {
        HttpResponseHeader HttpResponseHeader { get; set; }
        bool IsSuccessStatusCode { get; set; }
        string ReasonPhrase { get; set; }
        object ResponseBody { get; set; }
        int ResponseCode { get; set; }
        HttpStatusCode StatusCode { get; set; }
    }
}