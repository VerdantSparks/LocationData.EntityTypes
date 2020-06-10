namespace LocationData
{
    public interface IPlace<T1, T2> where T1 : IPlaceDetail
    {
        string Id { get; set; }
        T1 Details { get; set; }
        T2 BackingLocation { get; set; }
        Location Location { get; set; }
    }
}
