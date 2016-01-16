using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Reports;
using IfSwitchComparison;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenchmarkTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var reports = new BenchmarkRunner().Run<IfSwitchMethodContainer>();
            foreach (BenchmarkReport report in reports)
            {
                Console.WriteLine(report.ToString());
            }
        }
    }
}
