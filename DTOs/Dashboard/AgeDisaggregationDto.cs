using System.Text.Json.Serialization;

namespace MUCOBADI.DTOs.Dashboard
{
    public class AgeDisaggregationDto
    {
        [JsonPropertyName("admin_units")]
        public string adminUnits { get; set; }

        [JsonPropertyName("f_1")]
        public int? F_1 { get; set; }

        [JsonPropertyName("m_1")]
        public int? M_1 { get; set; }

        [JsonPropertyName("f_1_4")]
        public int? F_1_4 { get; set; }

        [JsonPropertyName("m_1_4")]
        public int? M_1_4 { get; set; }

        [JsonPropertyName("f_5_9")]
        public int? F_5_9 { get; set; }

        [JsonPropertyName("m_5_9")]
        public int? M_5_9 { get; set; }

        [JsonPropertyName("f_10_14")]
        public int? F_10_14 { get; set; }

        [JsonPropertyName("m_10_14")]
        public int? M_10_14 { get; set; }

        [JsonPropertyName("f_15_17")]
        public int? F_15_17 { get; set; }

        [JsonPropertyName("m_15_17")]
        public int? M_15_17 { get; set; }

        [JsonPropertyName("f_18_24")]
        public int? F_18_24 { get; set; }

        [JsonPropertyName("m_18_24")]
        public int? M_18_24 { get; set; }

        [JsonPropertyName("f_24")]
        public int? F_24 { get; set; }

        [JsonPropertyName("m_24")]
        public int? M_24 { get; set; }
    }
}
