namespace TemperatureApi.Models
{
    public class TemperatureResponse
    {
        public float Value { get; set; }
        public string Unit { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string SensorID { get; set; }
        public string SensorType { get; set; }
    }
}
