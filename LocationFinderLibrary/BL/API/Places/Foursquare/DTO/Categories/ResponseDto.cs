using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BL.API.Places.Foursquare.DTO.Categories
{
    public class ResponseDto
    {
        [JsonProperty("categories")]
        public List<RegularCategoryDto> Categories { get; set; }
    }
}
