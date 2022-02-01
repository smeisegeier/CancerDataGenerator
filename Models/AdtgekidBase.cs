using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rki.CancerDataGenerator.Models
{
    public abstract class AdtgekidBase
    {


        // have parameterless ctor for XmlSerializer
        public AdtgekidBase() {}


        /* Not working
        protected IEnumerable<AdtgekidBase> lol(int n, Type subType)
        {
            Type[] types = new Type[2];

            types[0] = typeof(Generator);
            types[1] = typeof(AdtgekidBase);

            var Menge = Enumerable
                .Range(1, n)
                .Select(index => subType.GetConstructor(types))
                .ToList();
            return Menge;
        }
        */

    }
}
