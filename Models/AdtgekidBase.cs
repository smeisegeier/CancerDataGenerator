namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public abstract class AdtgekidBase
    {
        // HACK to have context inside model is bad design, and its static
        public static DAL.AdtGekidDbContext _context { get; set; }
    }
}
