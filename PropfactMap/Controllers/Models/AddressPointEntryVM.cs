namespace PropfactMap.Controllers.Models
{
    public class AddressPointEntryVM
    {
        public string Search { get; set; }
        public int Zoom { get; set; }
        public NorthEastVM NorthEast { get; set; }
        public SouthWestVM SouthWest { get; set; }

    }

    public class NorthEastVM
    {
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }

    public class SouthWestVM
    {
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }
}
