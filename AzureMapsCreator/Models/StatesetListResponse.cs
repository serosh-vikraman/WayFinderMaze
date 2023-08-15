using System.Collections.Generic;

namespace AzureMapsCreator.Models
{
    public record StatesetListResponse
    {
        public List<StatesetInfoObject> statesets { get; set; }
    }



}
