using json.JsonMappedObjects;
using json.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Interfaces
{
    public interface IMetricsCalculator  
    {
        void CalculateMetrics(List<TestResult> testResults, MetricsCalculator metrics);
    }
}
