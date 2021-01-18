using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.GooglePlaces.DTO
{
    public class LocationDto
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }
}
