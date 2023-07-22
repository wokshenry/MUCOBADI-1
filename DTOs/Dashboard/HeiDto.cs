using System.Text.Json.Serialization;

namespace MUCOBADI.DTOs.Dashboard
{
    public class HeiDto
    {
        [JsonPropertyName("admin_units")]
        public string adminUnits { get; set; }

        [JsonPropertyName("infants")]
        public int? infants { get; set; }
    }

}
