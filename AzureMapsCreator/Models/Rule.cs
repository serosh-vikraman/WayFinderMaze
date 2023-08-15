using System.Text.Json.Serialization;

namespace AzureMapsCreator.Models
{
    public record Rule
    {
        [JsonPropertyName("true")]
        public string _true { get; init; }
        [JsonPropertyName("false")]
        public string _false { get; init; }
        public Range range { get; init; }
        public string color { get; init; }
    }

}
