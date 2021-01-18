using LocationFinderLibrary.BL.API.Places.Foursquare.DTO.Common;
using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.Foursquare.DTO.Venues
{
    public class VenuesResponseDto
    {
        [JsonProperty("meta")]
        public MetaDto Meta { get; set; }

        [JsonProperty("response")]
        public ResponseDto Response { get; set; }
    }
}
