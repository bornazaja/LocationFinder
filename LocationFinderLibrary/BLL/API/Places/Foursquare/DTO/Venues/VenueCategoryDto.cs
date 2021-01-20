using LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Common;
using Newtonsoft.Json;

namespace LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Venues
{
    public class VenueCategoryDto : BaseCategoryDto
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }
}
