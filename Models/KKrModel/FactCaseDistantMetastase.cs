using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactCaseDistantMetastase
    {
        public int CaseId { get; set; }
        public string DistantMetastasesId { get; set; }

        public virtual FactCase Case { get; set; }
        public virtual SfDistantMetastase DistantMetastases { get; set; }
    }
}
