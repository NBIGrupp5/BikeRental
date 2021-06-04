using BikeRental.Models;

namespace BikeRental.RequestsAndResponses
{
    public class AddBikeRequest
    {
        //comment
        public int BikeId { get; set; }
        public string FrameNumber { get; set; }
        public int BikeTypeId { get; set; }
    }
}