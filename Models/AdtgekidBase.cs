using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.Models.Dimensions;

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

    }
}
