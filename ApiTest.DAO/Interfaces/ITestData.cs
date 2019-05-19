using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTest.DAO.Interfaces
{
    public interface ITestData
    {
        ITestInput TestInput { get; set; }
        ITestOutput ExpectedResults { get; set; }
    }
}
