using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public abstract class AdtgekidBase
    {
        protected IGenerator _generator { get; }

        protected AdtgekidBase _parent { get; }

        public AdtgekidBase(IGenerator generator, AdtgekidBase parent)
        {
            _generator = generator;
            _parent = parent;
        }
        public AdtgekidBase() {}

    }
}
