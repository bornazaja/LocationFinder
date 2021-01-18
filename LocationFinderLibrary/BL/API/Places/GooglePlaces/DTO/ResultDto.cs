using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BL.API.Places.GooglePlaces.DTO
{
    public class ResultDto
    {
        [JsonProperty("geometry")]
        public GeometryDto Geometry { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("opening_hours")]
        public OpeningHoursDto OpeningHours { get; set; }

        [JsonProperty("photos")]
        public List<PhotoDto> Photos { get; set; }

        [JsonProperty("place_id")]
        public string PlaceID { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("types")]
        public List<string> Types { get; set; }

        [JsonProperty("vicinity")]
        public string Vicinity { get; set; }
    }
}
