using System.Text.Json.Serialization;

namespace MUCOBADI.DTOs.Dashboard
{
    public class BeneficiariesHivStatusDto
    {
        [JsonPropertyName("admin_units")]
        public string admin_units { get; set; }

        [JsonPropertyName("positive")]
        public int? positive { get; set; }

        [JsonPropertyName("negative")]
        public int? negative { get; set; }

        [JsonPropertyName("unknown")]
        public int? unknown { get; set; }
    }
}
