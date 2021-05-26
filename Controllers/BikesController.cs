using BikeRental.Models;
using BikeRental.RequestsAndResponses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BikesController : ControllerBase
    {
        private readonly BikeRentalContext _context;
        public BikesController(BikeRentalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BikeResponse>> GetAllBikes()
        {
            var bikesFromDb = _context.Bikes.ToList();
            var bikeResponses = bikesFromDb.Select(x => 
            new BikeResponse { 
                Id = x.Id,
                FrameNumber = x.FrameNumber
            });
            return Ok(bikeResponses);
        }

        [HttpGet("{bikeId:int}", Name = "GetBike")]
        public ActionResult<BikeResponse> GetBike(int bikeId)
        {
            var bikeFromDb = _context.Bikes.Find(bikeId);
            var bikeResponse = new BikeResponse
            {
                Id = bikeFromDb.Id,
                FrameNumber = bikeFromDb.FrameNumber
            };
            return Ok(bikeResponse);
        }

        [HttpPost]
        public async Task<ActionResult<BikeResponse>> AddBike([FromBody] AddBikeRequest request)
        {
            var bike = new Bike
            {
                FrameNumber = request.FrameNumber
            };

            _context.Bikes.Add(bike);
            await _context.SaveChangesAsync();

            var bikeResponse = new BikeResponse
            {
                FrameNumber = bike.FrameNumber,
                Id = bike.Id
            };
            return CreatedAtRoute(nameof(GetBike), new { bikeId = bikeResponse.Id }, bikeResponse);
        }

        [HttpDelete("{bikeId:int}")]
        public ActionResult DeleteBike(int bikeId)
        {
            var bikeFromDb = _context.Bikes.Find(bikeId);
            _context.Bikes.Remove(bikeFromDb);
            return NoContent();
        }
    }
}
