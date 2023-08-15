using System.Collections.Generic;

namespace AzureMapsCreator.Models
{
    public record DatasetSources
    {
        public List<string> conversionIds { get; init; }
        public string appendDatasetId { get; init; }
    }

}
