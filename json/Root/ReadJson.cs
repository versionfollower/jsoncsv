using json.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Root
{
    public class ReadJson : IReadJson
    {
        public string ReadJsonFile(string filePath)
        {
            // Implement JSON reading logic
            // You can use libraries like Newtonsoft.Json for this purpose
            // For simplicity, I'm using File.ReadAllText in this example
            return File.ReadAllText(filePath);
        }
    }
}
