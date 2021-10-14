using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactOperationAdditionalOp
    {
        public int OperationId { get; set; }
        public string Ops { get; set; }

        public virtual FactCaseOperation Operation { get; set; }
        public virtual SfOp OpsNavigation { get; set; }
    }
}
