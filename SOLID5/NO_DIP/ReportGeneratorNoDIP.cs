using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID5.NO_DIP
{
    public class ReportGenerator
    {
        private PDFReportNoDIP _pdfReport;

        public ReportGenerator()
        {
            _pdfReport = new PDFReportNoDIP();
        }

        public void Generate()
        {
            _pdfReport.GenerateReport();
        }
    }
}
