using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID5.WITH_DIP
{
    public class ExcelReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Relatório Excel gerado.");
        }
    }
}
