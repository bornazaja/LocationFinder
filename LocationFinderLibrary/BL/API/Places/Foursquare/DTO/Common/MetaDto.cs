using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.Foursquare.DTO.Common
{
    public class MetaDto
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("requestId")]
        public string RequestID { get; set; }
    }
}
