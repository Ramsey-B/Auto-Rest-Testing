using ApiTest.DAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;

namespace ApiTest.DAO.Data
{
    public class TestOutput : ITestOutput
    {
        public int ResponseCode { get; set; }
        public object ResponseBody { get; set; }
        public string ReasonPhrase { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessStatusCode { get; set; }
        public HttpResponseHeader HttpResponseHeader { get; set; }
    }
}
