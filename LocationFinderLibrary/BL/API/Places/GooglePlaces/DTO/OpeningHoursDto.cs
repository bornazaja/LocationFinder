using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BL.API.Places.GooglePlaces.DTO
{
    public class OpeningHoursDto
    {
        [JsonProperty("open_now")]
        public bool OpenNow { get; set; }
    }
}
