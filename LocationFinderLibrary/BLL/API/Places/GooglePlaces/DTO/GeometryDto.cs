using Newtonsoft.Json;

namespace LocationFinderLibrary.BLL.API.Places.GooglePlaces.DTO
{
    public class GeometryDto
    {
        [JsonProperty("location")]
        public LocationDto Location { get; set; }
    }
}
