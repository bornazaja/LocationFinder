using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Venues
{
    public class ResponseDto
    {
        [JsonProperty("venues")]
        public List<VenueDto> Venues { get; set; }
    }
}
