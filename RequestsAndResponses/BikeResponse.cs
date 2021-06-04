using BikeRental.Models;

namespace BikeRental.RequestsAndResponses
{
    public class BikeResponse
    {
        public int BikeId { get; set; }
        public string FrameNumber { get; set; }
        public int BikeTypeId { get; set; }
    }
}
