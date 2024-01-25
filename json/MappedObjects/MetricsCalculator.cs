using json.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.JsonMappedObjects
{
    public class MetricsCalculator
    {
        public int TotalTestCases { get;  set; }
        public int PassedTestCases { get;  set; }
        public int FailedTestCases { get;  set; }
        public double AverageExecutionTime { get;  set; }
        public double MinExecutionTime { get;  set; }
        public double MaxExecutionTime { get;  set; }

        
    }
}
