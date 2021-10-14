using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfHormoneReceptorStatus
    {
        public SfHormoneReceptorStatus()
        {
            FactModuleBreastCancerEstrogenStatusNavigations = new HashSet<FactModuleBreastCancer>();
            FactModuleBreastCancerHer2neuStatusNavigations = new HashSet<FactModuleBreastCancer>();
            FactModuleBreastCancerProgesteroneStatusNavigations = new HashSet<FactModuleBreastCancer>();
        }

        public string ReceptorStatusId { get; set; }
        public string ReceptorStatusShortname { get; set; }
        public string ReceptorStatusLongnameEnglish { get; set; }
        public string ReceptorStatusLongnameGerman { get; set; }

        public virtual ICollection<FactModuleBreastCancer> FactModuleBreastCancerEstrogenStatusNavigations { get; set; }
        public virtual ICollection<FactModuleBreastCancer> FactModuleBreastCancerHer2neuStatusNavigations { get; set; }
        public virtual ICollection<FactModuleBreastCancer> FactModuleBreastCancerProgesteroneStatusNavigations { get; set; }
    }
}
