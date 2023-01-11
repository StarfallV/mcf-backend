using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mcf_backend.Models;

namespace mcf_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageLocationController : ControllerBase
    {
        private readonly DataContext _context;

        public StorageLocationController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<MsStorageLocation>> Get()
        {
            return await _context.StorageLocations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var product = await _context.StorageLocations.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);

        }

        [HttpPost]
        public async Task<ActionResult> Post(MsStorageLocation data)
        {
            _context.Add(data);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(MsStorageLocation data)
        {
            if (data == null || data.Id == 0)
                return BadRequest();

            var _temp = await _context.StorageLocations.FindAsync(data.Id);
            if (_temp == null)
                return NotFound();

            _temp.location_id = data.location_id;
            _temp.location_name = data.location_name;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = await _context.StorageLocations.FindAsync(id);

            if (product == null) return NotFound();
            _context.StorageLocations.Remove(product);

            await _context.SaveChangesAsync();
            return Ok();

        }
    }
}