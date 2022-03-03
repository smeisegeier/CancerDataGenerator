using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Histologie
    {
        // TODO array vs list
        public Morphologie Morphologie { get; set; }

        public Grading_Typ Grading { get; set; }

        [Range(1,Int32.MaxValue)]
        public int LK_untersucht { get; set; }

        [Range(1, Int32.MaxValue)]
        public int LK_befallen { get; set; }
    }
}