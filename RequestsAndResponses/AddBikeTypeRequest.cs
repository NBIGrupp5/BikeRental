using BikeRental.Models;

namespace BikeRental.RequestsAndResponses
{
    public class AddBikeTypeRequest
    {
        public int Id { get; set; }
        public string BikeTypeName { get; set; }
        public float BikeTypePrice { get; set; }
        public string BikeTypeDescription { get; set; }
        public string BikeTypeImage { get; set; }
    }
}