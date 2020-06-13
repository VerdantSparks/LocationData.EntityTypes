using Newtonsoft.Json;

namespace LocationData.Mongo
{
    public abstract class GooglePlace<T> : Place<T>, IGooglePlace where T : IPlaceDetail
    {
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }
    }
}
