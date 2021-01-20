using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Categories
{
    public class ResponseDto
    {
        [JsonProperty("categories")]
        public List<RegularCategoryDto> Categories { get; set; }
    }
}
