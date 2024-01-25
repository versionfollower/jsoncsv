using json.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Interfaces
{
    public interface IWriteCsv
    {
        void WriteToCsv(IEnumerable<TestResult> data, string filePath);
    }
}
