using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Venues
{
    public class VenueDto
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public LocationDto Location { get; set; }

        [JsonProperty("categories")]
        public List<VenueCategoryDto> Categories { get; set; }

        [JsonProperty("venuePage")]
        public VenuePageDto VenuePage { get; set; }
    }
}
