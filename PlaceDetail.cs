using Newtonsoft.Json;

namespace LocationData
{
    public abstract class PlaceDetail : IPlaceDetail
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
