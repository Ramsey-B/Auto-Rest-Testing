using ApiTest.DAO.Attributes;
using ApiTest.DAO.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTest.DAO.Data
{
    [TestClass]
    public class TestData : ITestData
    {
        public ITestInput TestInput { get; set; }
        public ITestOutput ExpectedResults { get; set; }
    }
}
