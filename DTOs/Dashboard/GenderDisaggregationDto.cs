using System.Text.Json.Serialization;

namespace MUCOBADI.DTOs.Dashboard
{
    public class GenderDisaggregationDto
    {
        [JsonPropertyName("admin_units")]
        public string admin_units { get; set; }

        [JsonPropertyName("m")]
        public int? M { get; set; }

        [JsonPropertyName("f")]
        public int? F { get; set; }
    }
}
