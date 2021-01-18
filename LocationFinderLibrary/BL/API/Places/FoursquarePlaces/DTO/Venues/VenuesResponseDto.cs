using LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Common;
using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Venues
{
    public class VenuesResponseDto
    {
        [JsonProperty("meta")]
        public MetaDto Meta { get; set; }

        [JsonProperty("response")]
        public ResponseDto Response { get; set; }
    }
}
