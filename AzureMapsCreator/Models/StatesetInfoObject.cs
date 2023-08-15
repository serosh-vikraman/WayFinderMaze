using System.Collections.Generic;

namespace AzureMapsCreator.Models
{
    public record StatesetInfoObject
    {
        public string statesetId { get; init; }
        public string description { get; init; } = "";
        public List<string> datasetIds { get; init; }
        public Statesetstyle statesetStyle { get; init; }
    }

}
