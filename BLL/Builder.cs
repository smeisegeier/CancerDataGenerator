using Rki.CancerDataGenerator.Models.Dimensions;
using Rki.CancerDataGenerator.Models.ADTGEKID;
using System;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.BLL
{
    public class Builder
    {
        private IGenerator _generator { get; }

        private ADT_GEKID root { get; } = new ADT_GEKID();

        public Builder(IGenerator generator)
        {
            _generator = generator;
            init();
        }

        private void init()
        {
            root.Menge_Patient = new List<Patient>();
            for (int i = 0; i < _generator.CreateFixedValuePatientCount(); i++)
            {
                root.Menge_Patient.Add(new Patient());
            }

        }
    }
}
