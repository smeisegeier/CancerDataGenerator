﻿namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class TherapyLine : _DimensionBase
    {
        public int therapy_line_id { get; set; }
        public string therapy_line_shortname { get; set; }
        public string therapy_line_longname_english { get; set; }
        public string therapy_line_longname_german { get; set; }

    }
}
