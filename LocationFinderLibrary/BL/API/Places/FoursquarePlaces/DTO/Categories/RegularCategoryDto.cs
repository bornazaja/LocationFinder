using LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Categories
{
    public class RegularCategoryDto : BaseCategoryDto
    {
        [JsonProperty("categories")]
        public List<RegularCategoryDto> Categories { get; set; }
    }
}
