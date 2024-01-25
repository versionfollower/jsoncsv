using json.JsonMappedObjects;
using json.Root;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonfile = "result.json";
            string csvfile = "output.csv";


            // Get the directory where the executable is located
            string executableDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string projectRoot = Directory.GetParent(executableDirectory)?.Parent?.FullName;

            // Combine the executable directory with the relative path to the file
            string jsonrelativePath = Path.Combine(projectRoot, jsonfile);
            string csvrelativePath = Path.Combine(projectRoot, csvfile);

            // Using relative path

            // Navigate up one directory level to reach the project root
            


            //string jsonFilePath = @"C:\Users\EDDY\source\repos\json\json\result.json";
            //string test = ".\result.json";
            //string csvFilePath = @"C:\Users\EDDY\source\repos\json\json\output.csv";

            var jsonReader = new ReadJson();
            var csvWriter = new WriteCsv();
            var converter = new JsonConvertCsv(jsonReader, csvWriter);
            var generateMetrics = new GenerateMetrics();
            var metricsCalculator = new MetricsCalculator();
            var tests = converter.Convert(jsonrelativePath, csvrelativePath);
            generateMetrics.CalculateMetrics(tests, metricsCalculator);

            Console.WriteLine("Conversion complete.");
            Console.ReadLine();
        }
    }
}
