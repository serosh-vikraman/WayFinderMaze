using System.Collections.Generic;

namespace AzureMapsCreator.Models
{
    public record DatasetListResponse
    {
        public List<DatasetDetailInfo> datasets { get; set; }
    }

}
