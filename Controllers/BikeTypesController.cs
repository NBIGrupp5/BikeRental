using BikeRental.Models;
using BikeRental.RequestsAndResponses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace BikeRental.Controllers
{
    [ApiController]
    [Route("api/biketypes")]
    public class BikeTypesController : ControllerBase
    {
        private readonly BikeRentalContext _context;
        public BikeTypesController(BikeRentalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BikeTypeResponse>> GetAllBikeTypes()
        {
            try
            {
                var bikeTypesFromDb = _context.BikeTypes.ToList();
                var bikeTypeResponses = bikeTypesFromDb.Select(x =>
                new BikeTypeResponse
                {
                    Id = x.Id,
                    BikeTypeName = x.BikeTypeName,
                    BikeTypePrice = x.BikeTypePrice,
                    BikeTypeDescription = x.BikeTypeDescription,
                    BikeTypeImage = x.BikeTypeImage
                });
                return Ok(bikeTypeResponses);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpGet("{Id:int}", Name = "GetBikeType")]
        public ActionResult<BikeTypeResponse> GetBikeType(int Id)
        {
            var bikeTypeFromDb = _context.BikeTypes.Find(Id);
            if (bikeTypeFromDb == null)
            {
                return NotFound($"Can not find Bike Type with Id = {Id}.");
            }
            var bikeTypeResponse = new BikeTypeResponse
            {
                Id = bikeTypeFromDb.Id,
                BikeTypeName = bikeTypeFromDb.BikeTypeName,
                BikeTypePrice = bikeTypeFromDb.BikeTypePrice,
                BikeTypeDescription = bikeTypeFromDb.BikeTypeDescription,
                BikeTypeImage = bikeTypeFromDb.BikeTypeImage
            };
            return Ok(bikeTypeResponse);
        }

        [HttpPost]
        public async Task<ActionResult<BikeTypeResponse>> AddBikeType([FromBody] AddBikeTypeRequest request)
        {
            var bikeType = new BikeType
            {
                BikeTypeName = request.BikeTypeName,
                BikeTypePrice = request.BikeTypePrice,
                BikeTypeDescription = request.BikeTypeDescription,
                BikeTypeImage = request.BikeTypeImage
            };

            _context.BikeTypes.Add(bikeType);
            await _context.SaveChangesAsync();

            var bikeTypeResponse = new BikeTypeResponse
            {
                Id = bikeType.Id,
                BikeTypeName = bikeType.BikeTypeName,
                BikeTypePrice = bikeType.BikeTypePrice,
                BikeTypeDescription = bikeType.BikeTypeDescription,
                BikeTypeImage = bikeType.BikeTypeImage
            };
            return CreatedAtAction(nameof(AddBikeType), new { bikeTypeId = bikeTypeResponse.Id }, bikeTypeResponse);
        }

        [HttpDelete("{Id:int}")]
        public ActionResult DeleteType(int Id)
        {
            var typeToDelete = _context.BikeTypes.Find(Id);
            if (typeToDelete == null)
            {
                return BadRequest($"Bike Type with Id = {Id} not found. Can not delete.");
            }
            _context.BikeTypes.Remove(typeToDelete);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
