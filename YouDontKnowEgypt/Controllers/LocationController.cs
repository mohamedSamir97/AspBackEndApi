using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouDontKnowEgypt.Models;
using YouDontKnowEgypt.Models.Pagination;
using YouDontKnowEgypt.Repository;

namespace YouDontKnowEgypt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        YouDontKnowEgyptContext db;
        private ILocationRepository _locationRepository;

        public LocationController(ILocationRepository locationRepository, YouDontKnowEgyptContext _db)
        {
            _locationRepository = locationRepository;
            db = _db;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> getLocations([FromQuery] PagingParameters pagingParameters)
        {

            return await _locationRepository.getLocations(pagingParameters);
             
        }
        [HttpGet("{id}")]
        public ActionResult getById(int id)
        {
            Location l = db.Locations.Find(id);
            if (l == null)
            {
                return NotFound();
            }
            return Ok(l);
        }
        [HttpPost]
        public ActionResult create(Location l)
        {
            if (l == null)
            {
                return BadRequest();
            }
            db.Locations.Add(l);
            db.SaveChanges();
            return Created($"location with name {l.Name}", l);
        }
    }
}
