using Microsoft.Azure.Cosmos.Spatial;
using Newtonsoft.Json;

namespace LocationData.Cosmos
{
    public class Place<T> : IPlace<T, Point> where T : IPlaceDetail
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("details")]
        public T Details { get; set; }

        [JsonProperty("backing_location")]
        public Point BackingLocation { get; set; }

        [JsonIgnore]
        [JsonProperty("location")]
        public Location Location
        {
            get => new Location{Longitude = BackingLocation.Position.Longitude, Latitude = BackingLocation.Position.Latitude};
            set => BackingLocation = new Point(value.Longitude, value.Latitude);
        }
    }
}
