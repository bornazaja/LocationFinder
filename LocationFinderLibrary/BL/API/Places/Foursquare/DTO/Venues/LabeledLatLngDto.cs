using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.Foursquare.DTO.Venues
{
    public class LabeledLatLngDto
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }
}
