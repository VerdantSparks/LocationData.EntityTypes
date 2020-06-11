namespace LocationData
{
    public interface IPlaceConverter<in T1, TVendorSpecificLocationStorage>
    {
        IPlace<IPlaceDetail, TVendorSpecificLocationStorage> Convert(T1 input);
    }
}
