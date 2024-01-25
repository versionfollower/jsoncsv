using json.Interfaces;
using json.JsonMappedObjects;
using json.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Root
{
    public class GenerateMetrics : IMetricsCalculator
    {

        public void CalculateMetrics(List<TestResult> testResults, MetricsCalculator metrics)
        {
            metrics.TotalTestCases = testResults.Count;

            foreach (var test in testResults)
            {
                if (test.status.Equals("Pass"))
                {
                    metrics.PassedTestCases++;
                }
                else if (test.status.Equals("Fail"))
                {
                    metrics.FailedTestCases++;
                }

                metrics.AverageExecutionTime += test.execution_time;

                if (test.execution_time < metrics.MinExecutionTime || metrics.MinExecutionTime == 0)
                {
                    metrics.MinExecutionTime = test.execution_time;
                }

                if (test.execution_time > metrics.MaxExecutionTime)
                {
                    metrics.MaxExecutionTime = test.execution_time;
                }
            }

            metrics.AverageExecutionTime /= metrics.TotalTestCases;
            PrintingData(metrics);
        }
        //Printing the Object, this could be added to a csv or generate as a Json Object or send to the database or send to an HTML Report
 
        public void PrintingData(MetricsCalculator metrics)
        {
            Console.WriteLine("Total Test Cases : " + metrics.TotalTestCases);
            Console.WriteLine("Total Passed Tests : " + metrics.PassedTestCases);
            Console.WriteLine("Total Failed Tests : " + metrics.FailedTestCases);
            Console.WriteLine("Total Average Execution Time : " + metrics.AverageExecutionTime);
            Console.WriteLine("Total Max Execution time for a test : " + metrics.MaxExecutionTime);
            Console.WriteLine("Total Min Execution time for a test : " + metrics.MinExecutionTime);
            
        }
    }
        
}
