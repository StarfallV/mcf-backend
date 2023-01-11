using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mcf_backend.Models;

namespace mcf_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BpkbController : ControllerBase
    {
        private readonly DataContext _context;

        public BpkbController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<TrBpkb>> Get()
        {
            return await _context.BPKBs.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var product = await _context.BPKBs.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);

        }

        [HttpPost]
        public async Task<ActionResult> Post(TrBpkb data)
        {
            _context.Add(data);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(TrBpkb data)
        {
            if (data == null || data.Id == 0)
                return BadRequest();

            var _temp = await _context.BPKBs.FindAsync(data.Id);
            if (_temp == null)
                return NotFound();

            _temp.agreement_number = data.agreement_number;
            _temp.branch_id = data.branch_id;
            _temp.bpkb_no = data.bpkb_no;
            _temp.bpkb_date_in = data.bpkb_date_in;
            _temp.bpkb_date = data.bpkb_date;
            _temp.faktur_no = data.faktur_no;
            _temp.faktur_date = data.faktur_date;
            _temp.police_no = data.police_no;
            _temp.location_id = data.location_id;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = await _context.BPKBs.FindAsync(id);

            if (product == null) return NotFound();
            _context.BPKBs.Remove(product);

            await _context.SaveChangesAsync();
            return Ok();

        }
    }
}