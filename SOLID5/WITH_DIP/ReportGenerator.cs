using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID5.WITH_DIP
{
    public class ReportGenerator
    {
        private readonly IReport _report;

        public ReportGenerator(IReport report)
        {
            _report = report;
        }

        public void Generate()
        {
            _report.GenerateReport();
        }
    }
}
