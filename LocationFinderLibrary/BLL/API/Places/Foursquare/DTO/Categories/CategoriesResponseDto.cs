﻿using LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Common;
using Newtonsoft.Json;

namespace LocationFinderLibrary.BLL.API.Places.Foursquare.DTO.Categories
{
    public class CategoriesResponseDto
    {
        [JsonProperty("meta")]
        public MetaDto Meta { get; set; }

        [JsonProperty("response")]
        public ResponseDto Response { get; set; }
    }
}
