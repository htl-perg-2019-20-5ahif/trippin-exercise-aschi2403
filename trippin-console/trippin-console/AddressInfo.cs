namespace trippin_console
{
    internal class AddressInfo
    {
        public string Address { get; set; }
        public City City { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public string CountryRegion { get; set; }
        public string Region { get; set; }
    }
}