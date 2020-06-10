namespace LocationData
{
    public interface IPlaceConverter<in T>
    {
        IPlaceDetail Convert(T input);
    }
}
