using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfCareProvider
    {
        public SfCareProvider()
        {
            FactCaseOperations = new HashSet<FactCaseOperation>();
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
            FactCases = new HashSet<FactCase>();
        }

        public int CareProviderId { get; set; }
        public string CareProviderInstitution { get; set; }
        public string CareProviderDepartment { get; set; }
        public string CareProviderProfession { get; set; }
        public string CareProviderName { get; set; }

        public virtual ICollection<FactCaseOperation> FactCaseOperations { get; set; }
        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
