using System.Collections.Generic;

namespace AzureMapsCreator.Models
{
    public record TilesetListResponse
    {
        public List<TilesetDetailInfo> tilesets { get; set; }
    }

}
