using System.Collections.Generic;

namespace AzureMapsCreator.Models
{
    public record MapDataListResponse
    {
        public List<MapDataDetailInfo> mapDataList { get; set; }
    }
}
