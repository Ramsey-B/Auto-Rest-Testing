using ApiTest.DAO.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTest.TestFramework.TestRunners
{
    public interface ITestRunner
    {
        List<TestResult> RunTests();
    }
}
