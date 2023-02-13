namespace PropfactMap.Models.DTOs
{
    public class AddressPointEntryDTO
    {
        public string Search { get; set; }
        public int Zoom { get; set; }
        public NorthEastDTO NorthEast { get; set; }
        public SouthWestDTO SouthWest { get; set; }

    }

    public class NorthEastDTO
    {
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }

    public class SouthWestDTO
    {
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }
}
