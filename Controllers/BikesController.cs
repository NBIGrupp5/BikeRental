using BikeRental.Models;
using BikeRental.RequestsAndResponses;
using Microsoft.AspNetCore.Mvc;
using System;
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
            try
            {
                var bikesFromDb = _context.Bikes.ToList();
                var bikeResponses = bikesFromDb.Select(x =>
                new BikeResponse
                {
                    BikeId = x.BikeId,
                    FrameNumber = x.FrameNumber,
                    BikeTypeId = x.BikeTypeId
                });
                return Ok(bikeResponses);
            }
            catch (Exception) 
            {
                throw;
            }
            
        }

        [HttpGet("{bikeId:int}", Name = "GetBike")]
        public ActionResult<BikeResponse> GetBike(int bikeId)
        {
            var bikeFromDb = _context.Bikes.Find(bikeId);
            if (bikeFromDb == null)
            {
                return NotFound($"Bicycle with Id = {bikeId} doesn't exist.");
            }
            var bikeResponse = new BikeResponse
            {
                BikeId = bikeFromDb.BikeId,
                FrameNumber = bikeFromDb.FrameNumber,
                BikeTypeId = bikeFromDb.BikeTypeId
            };
            return Ok(bikeResponse);
        }

        [HttpPost]
        public async Task<ActionResult<BikeResponse>> AddBike([FromBody] AddBikeRequest request)
        {
            var bike = new Bike
            {
                FrameNumber = request.FrameNumber,
                BikeTypeId = request.BikeTypeId
            };

            _context.Bikes.Add(bike);
            await _context.SaveChangesAsync();

            var bikeResponse = new BikeResponse
            {
                FrameNumber = bike.FrameNumber,
                BikeId = bike.BikeId,
                BikeTypeId = bike.BikeTypeId
            };
            return CreatedAtRoute(nameof(GetBike), new { bikeId = bikeResponse.BikeId }, bikeResponse);
        }

        [HttpDelete("{bikeId:int}")]
        public ActionResult DeleteBike(int bikeId)
        {
            var bikeToDelete = _context.Bikes.Find(bikeId);
            if (bikeToDelete == null)
            {
                return BadRequest($"Bicycle with Id = {bikeId} can not be deleted, because it doesn't exist.");
            }
            _context.Bikes.Remove(bikeToDelete);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
