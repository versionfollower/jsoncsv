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
            //Files names
            string jsonfile = "result.json";
            string csvfile = "output.csv";


            // Get the directory where the executable is located and get the parent directory
            string executableDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string projectRoot = Directory.GetParent(executableDirectory)?.Parent?.FullName;

            // Combine the executable directory with the relative path to the file
            string jsonrelativePath = Path.Combine(projectRoot, jsonfile);
            string csvrelativePath = Path.Combine(projectRoot, csvfile);

            //Intances Objects
            var jsonReader = new ReadJson();
            var csvWriter = new WriteCsv();
            var generateMetrics = new GenerateMetrics();
            var metricsCalculator = new MetricsCalculator();
            var converter = new JsonConvertCsv(jsonReader, csvWriter);

            //convert the json to Csv using the relatives paths from json and csv file
            //and save in tests variable all the information that are in the json file
            var tests = converter.Convert(jsonrelativePath, csvrelativePath);
            //Use the data in tests variable and generate metrics 
            generateMetrics.CalculateMetrics(tests, metricsCalculator);

            Console.WriteLine("Conversion complete.");
            Console.ReadLine();
        }
    }
}
