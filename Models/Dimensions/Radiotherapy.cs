namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class Radiotherapy : DimensionBase
    {
    public string radiotherapy_id { get; set; }
    public string radiotherapy_target_area_rough { get; set; }
    public string radiotherapy_target_area_fine { get; set; }
    public string radiotherapy_target_area_finest { get; set; }
    public string radiotherapy_lymph_nodes { get; set; }
    public string radiotherapy_description_english { get; set; }
    public string radiotherapy_description_german { get; set; }

    }
}
