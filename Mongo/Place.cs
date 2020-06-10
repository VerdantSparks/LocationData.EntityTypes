using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using Newtonsoft.Json;

namespace LocationData.Mongo
{
    public abstract class Place<T> : IPlace<T, GeoJsonPoint<GeoJson2DGeographicCoordinates>> where T : IPlaceDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("details")]
        public T Details { get; set; }

        [JsonProperty("backing_location")]
        public GeoJsonPoint<GeoJson2DGeographicCoordinates> BackingLocation { get; set; }

        [BsonIgnore]
        [JsonProperty("location")]
        public Location Location
        {
            get =>
                new Location
                {
                    Latitude = BackingLocation.Coordinates.Latitude,
                    Longitude = BackingLocation.Coordinates.Longitude
                };
            set =>
                BackingLocation = new GeoJsonPoint<GeoJson2DGeographicCoordinates>(
                    new GeoJson2DGeographicCoordinates(value.Longitude, value.Latitude));
        }
    }
}
