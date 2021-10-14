using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactCaseReportType
    {
        public int CaseId { get; set; }
        public string ReportTypeId { get; set; }
        public int NumberOfReports { get; set; }

        public virtual FactCase Case { get; set; }
        public virtual SfReportType ReportType { get; set; }
    }
}
