using System.Collections.Generic;

namespace AzureMapsCreator.Models
{
    public record ConversionListResponse
    {
        public List<ConversionListDetailInfo> conversions { get; set; }
    }

}
