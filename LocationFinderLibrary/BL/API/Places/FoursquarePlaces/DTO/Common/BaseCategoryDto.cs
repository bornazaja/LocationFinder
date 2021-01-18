using Newtonsoft.Json;

namespace LocationFinderLibrary.BL.API.Places.FoursquarePlaces.DTO.Common
{
    public abstract class BaseCategoryDto
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plurarName")]
        public string PlurarName { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("icon")]
        public IconDto Icon { get; set; }
    }
}
