﻿using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.Foursquare.DTO.Venues
{
    public class VenuePageDto
    {
        [JsonProperty("id")]
        public string id { get; set; }
    }
}