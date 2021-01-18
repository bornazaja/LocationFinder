using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.GooglePlaces.DTO
{
    public class GeometryDto
    {
        [JsonProperty("location")]
        public LocationDto Location { get; set; }
    }
}
