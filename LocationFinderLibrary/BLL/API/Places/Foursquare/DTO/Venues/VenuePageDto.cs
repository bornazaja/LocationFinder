using Newtonsoft.Json;

namespace LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Venues
{
    public class VenuePageDto
    {
        [JsonProperty("id")]
        public string id { get; set; }
    }
}
