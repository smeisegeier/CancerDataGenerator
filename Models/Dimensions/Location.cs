namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class Location : DimensionBase
    {
        public string location_id { get; set; }
        public string location_state { get; set; }
        public new string Name => location_state;
    }
}

