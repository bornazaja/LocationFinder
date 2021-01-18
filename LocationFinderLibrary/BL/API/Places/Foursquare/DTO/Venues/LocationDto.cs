using Newtonsoft.Json;
using System.Collections.Generic;

namespace LocationFinderLibrary.BL.API.Places.Foursquare.DTO.Venues
{
    public class LocationDto
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("crossAddress")]
        public string CrossAddress { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lng")]
        public double Longitude { get; set; }

        [JsonProperty("labeledLatLngs")]
        public List<LabeledLatLngDto> LabeledLatLngs { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("cc")]
        public string CC { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("formatedAddress")]
        public List<string> FormatedAdress { get; set; }
    }
}
