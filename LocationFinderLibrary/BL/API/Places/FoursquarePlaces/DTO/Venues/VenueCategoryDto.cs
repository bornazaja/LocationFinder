using LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Common;
using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Venues
{
    public class VenueCategoryDto : BaseCategoryDto
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }
}
