using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BLL.API.Places.GooglePlaces.DTO
{
    public class PlacesResponseDto
    {
        [JsonProperty("html_attributions")]
        public List<object> HtmlAttributions { get; set; }

        [JsonProperty("results")]
        public List<ResultDto> Results { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
