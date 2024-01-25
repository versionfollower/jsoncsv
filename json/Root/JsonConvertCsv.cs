using json.Interfaces;
using json.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Root
{
    public class JsonConvertCsv
    {
        private readonly IReadJson jsonReader;
        private readonly IWriteCsv csvWriter;

        public JsonConvertCsv(IReadJson jsonReader, IWriteCsv csvWriter)
        {
            this.jsonReader = jsonReader;
            this.csvWriter = csvWriter;
        }

        public List<TestResult> Convert(string jsonFilePath, string csvFilePath)
        {
            string jsonContent = jsonReader.ReadJsonFile(jsonFilePath);

            // Deserialize JSON to list of Person objects
            List<TestResult> tests = JsonConvert.DeserializeObject<List<TestResult>>(jsonContent);

            // Write the list of persons to CSVs
            csvWriter.WriteToCsv(tests, csvFilePath);
            return tests;
        }
    }
}
