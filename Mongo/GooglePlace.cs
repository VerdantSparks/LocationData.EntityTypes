using Newtonsoft.Json;

namespace LocationData.Mongo
{
    public class GooglePlace<T> : Place<T> where T : IPlaceDetail, IGooglePlace
    {
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }
    }
}
