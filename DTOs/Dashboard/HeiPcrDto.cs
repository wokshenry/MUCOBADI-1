using System.Text.Json.Serialization;

namespace MUCOBADI.DTOs.Dashboard
{
    public class HeiPcrDto
    {
        [JsonPropertyName("admin_units")]
        public string adminUnits { get; set; }

        [JsonPropertyName("pcR_1")]
        public int? PCR_1 { get; set; }

        [JsonPropertyName("pcR_2")]
        public int? PCR_2 { get; set; }

        [JsonPropertyName("pcR_3")]
        public int? PCR_3 { get; set; }
    }

}
