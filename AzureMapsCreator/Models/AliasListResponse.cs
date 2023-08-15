using System.Collections.Generic;

namespace AzureMapsCreator.Models
{
    public record AliasListResponse
    {
        public List<AliasListItem> aliases { get; set; }
    }

}
