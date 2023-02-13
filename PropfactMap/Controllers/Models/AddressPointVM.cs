namespace PropfactMap.Controllers.Models
{
    public class AddressPointVM
    {
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? Title { get; set; }
    }

    public class AddressPointWrapperVM
    {
        public List<AddressPointVM> Results { get; set; }

    }
}
