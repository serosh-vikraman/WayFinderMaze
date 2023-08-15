namespace AzureMapsCreator.Models
{
    public record Geometry
    {
        public string type { get; init; }
        public float[][][] coordinates { get; init; }
    }
}
