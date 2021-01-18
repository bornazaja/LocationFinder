using LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Common;
using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Categories
{
    public class CategoriesResponseDto
    {
        [JsonProperty("meta")]
        public MetaDto Meta { get; set; }

        [JsonProperty("response")]
        public ResponseDto Response { get; set; }
    }
}
