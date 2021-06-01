using BikeRental.Models;
using BikeRental.RequestsAndResponses;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
            var bikeTypesFromDb = _context.BikeTypes.ToList();
            var bikeTypeResponses = bikeTypesFromDb.Select(x => 
            new BikeTypeResponse {
                Id = x.Id,
                BikeTypeName = x.BikeTypeName,
                BikeTypePrice = x.BikeTypePrice
            });
            return Ok(bikeTypeResponses);
        }

        [HttpGet("{Id:int}", Name = "GetBikeType")]
        public ActionResult<BikeTypeResponse> GetBikeType(int Id)
        {
            var bikeTypeFromDb = _context.BikeTypes.Find(Id);
            var bikeTypeResponse = new BikeTypeResponse
            {
                Id = bikeTypeFromDb.Id,
                BikeTypeName = bikeTypeFromDb.BikeTypeName,
                BikeTypePrice = bikeTypeFromDb.BikeTypePrice
            };
            return Ok(bikeTypeResponse);
        }

        [HttpPost]
        public async Task<ActionResult<BikeTypeResponse>> AddBikeType([FromBody] AddBikeTypeRequest request)
        {
            var bikeType = new BikeType
            {
                BikeTypeName = request.BikeTypeName,
                BikeTypePrice = request.BikeTypePrice
            };

            _context.BikeTypes.Add(bikeType);
            await _context.SaveChangesAsync();

            var bikeTypeResponse = new BikeTypeResponse
            {
                Id = bikeType.Id,
                BikeTypeName = bikeType.BikeTypeName,
                BikeTypePrice = bikeType.BikeTypePrice
            };
            return CreatedAtRoute(nameof(GetBikeType), new { bikeTypeId = bikeTypeResponse.Id }, bikeTypeResponse);
        }

        [HttpDelete("{Id:int}")]
        public ActionResult DeleteType(int Id)
        {
            var typeToDelete = _context.BikeTypes.Find(Id);
            _context.BikeTypes.Remove(typeToDelete);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
