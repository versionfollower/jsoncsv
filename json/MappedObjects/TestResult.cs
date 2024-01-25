using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Objects
{

    public class TestResult
    {
        public string test_case_name { get; set; }
        public string status { get; set; }
        public double execution_time { get; set; }
        public DateTime timestamp { get; set; }
    }

}



