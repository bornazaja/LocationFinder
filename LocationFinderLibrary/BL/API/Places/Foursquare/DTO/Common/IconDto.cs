using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.Foursquare.DTO.Common
{
    public class IconDto
    {
        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
    }
}
