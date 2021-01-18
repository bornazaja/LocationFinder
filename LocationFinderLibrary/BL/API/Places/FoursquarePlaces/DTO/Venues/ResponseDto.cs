﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Venues
{
    public class ResponseDto
    {
        [JsonProperty("venues")]
        public List<VenueDto> Venues { get; set; }
    }
}
