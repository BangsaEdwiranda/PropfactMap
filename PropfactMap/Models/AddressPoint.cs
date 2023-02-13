namespace PropfactMap.Models
{
    public class AddressPoint
    {
        public int Id { get; set; }
        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public string? County { get; set; }
        public string? AddressType { get; set; }
        public string? PropAddrL1 { get; set; }
        public string? PropAddrL2 { get; set; }
        public decimal? Angle { get; set; }
        public decimal? PointX { get; set; }
        public decimal? PointY { get; set; }
    }
}
