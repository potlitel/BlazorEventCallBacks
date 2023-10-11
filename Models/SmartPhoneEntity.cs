namespace BlazorEventCallBacks.Models
{
    public class SmartPhoneEntity
    {
        public int Id { get; set; }
        public string SmartPhoneName { get; set; } = null!;

        public bool IsAvailable { get; set; }

        public string Price { get; set; } = null!;

        public List<Feature> SmartPhoneFeatures { get; set; } = new List<Feature>();
    }

    public class Feature
    {
        public string Specification { get; set; } = null!;

        public string Value { get; set; } = null!;
    }
}