namespace BikeRental.Models
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string FrameNumber { get; set; }
        public string BikeTypeName { get; set; }
        public BikeType BikeType { get; set; }
    }
}
