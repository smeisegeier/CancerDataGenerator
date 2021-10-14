using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfReportType
    {
        public SfReportType()
        {
            FactCaseReportTypes = new HashSet<FactCaseReportType>();
        }

        public string ReportTypeId { get; set; }
        public string ReportTypeShortname { get; set; }
        public string ReportTypeLongnameEnglish { get; set; }
        public string ReportTypeLongnameGerman { get; set; }

        public virtual ICollection<FactCaseReportType> FactCaseReportTypes { get; set; }
    }
}
