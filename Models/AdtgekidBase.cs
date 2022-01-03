using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models
{
    public abstract class AdtgekidBase
    {
        protected IGenerator _generator { get; }

        protected AdtgekidBase _parent { get; }

        /// <summary>
        /// ctor for maintaining class integrity
        /// </summary>
        /// <param name="generator">stored _generator object</param>
        /// <param name="parent">this</param>
        public AdtgekidBase(IGenerator generator, AdtgekidBase parent)
        {
            _generator = generator;
            _parent = parent;
        }

        // have parameterless ctor for XmlSerializer
        public AdtgekidBase() {}

    }
}
