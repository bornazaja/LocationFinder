using LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Categories
{
    public class RegularCategoryDto : BaseCategoryDto
    {
        [JsonProperty("categories")]
        public List<RegularCategoryDto> Categories { get; set; }
    }
}
