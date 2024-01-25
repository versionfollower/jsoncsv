using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Interfaces
{
    public interface IReadJson
    {
        string ReadJsonFile(string filePath);
    }
}
