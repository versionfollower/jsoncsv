using json.Interfaces;
using json.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Root
{
    public class WriteCsv : IWriteCsv
    {
        public void WriteToCsv(IEnumerable<TestResult> test_results, string filePath)
        {
            // Implement CSV writing logic
            // For simplicity, I'm using StringBuilder in this example
            StringBuilder csvContent = new StringBuilder();

            // Write header
            csvContent.AppendLine("Test Case Name,Status ,Time, Timestamp");

            // Write data
            foreach (var test_result in test_results)
            {
                csvContent.AppendLine($"{test_result.test_case_name},{test_result.status},{test_result.execution_time},{test_result.timestamp}");
            }

            // Write to file
            File.WriteAllText(filePath, csvContent.ToString());
        }
    }
}
