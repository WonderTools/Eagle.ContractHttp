using System.Collections.Generic;
using WonderTools.Eagle.Contract;

namespace WonderTools.Eagle.HttpContract
{
    public class TestReport
    {
        public List<TestSuite> TestSuites { get; set; }
        public List<TestResult> TestResults { get; set; }
        public string NodeName { get; set; }
        public string RequestId { get; set; }
    }
}