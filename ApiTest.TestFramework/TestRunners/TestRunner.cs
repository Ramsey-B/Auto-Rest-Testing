using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ApiTest.DAO.Attributes;
using ApiTest.DAO.Data;

namespace ApiTest.TestFramework.TestRunners
{
    public class TestRunner : ITestRunner
    {
        public List<TestResult> RunTests()
        {
            var testResults = new List<TestResult>();

            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            var testClasses = types.Where(x => x.IsClass && x.IsPublic && x.CustomAttributes.Any(att => att.AttributeType == typeof(TestDataAttribute)));
            foreach (var testClass in testClasses)
            {
                var testResult = new TestResult();
                testResult.Name = testClass.Name;
                try
                {
                    testResult.Success = true;
                }
                catch(Exception ex)
                {
                    testResult.Success = false;
                    testResult.ErrorMessage = ex.Message;
                }
                finally
                {
                    testResults.Add(testResult);
                }
            }

            return testResults;
        }
    }
}
