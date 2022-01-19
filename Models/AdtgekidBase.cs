using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rki.CancerDataGenerator.Models
{
    public abstract class AdtgekidBase
    {
        protected Generator _generator { get; }

        protected AdtgekidBase _caller { get; }

        protected Configuration _config => _generator._config;

        /// <summary>
        /// ctor for maintaining class integrity
        /// </summary>
        /// <param name="generator">stored _generator object</param>
        /// <param name="caller">this</param>
        public AdtgekidBase(Generator generator, AdtgekidBase caller)
        {
            _generator = generator;
            _caller = caller;
        }

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
