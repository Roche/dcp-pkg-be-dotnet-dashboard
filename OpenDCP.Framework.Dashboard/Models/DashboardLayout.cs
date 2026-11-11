using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace OpenDCP.Framework.Dashboard.Models
{
    public class DashboardLayout
    {
        [JsonProperty("columnStart")]
        [JsonPropertyName("columnStart")]
        public int ColumnStart { get; set; }
        [JsonProperty("rowStart")]
        [JsonPropertyName("rowStart")]
        public int RowStart { get; set; }
        [JsonProperty("columnEnd")]
        [JsonPropertyName("columnEnd")]
        public string ColumnEnd { get; set; }
    }
}
