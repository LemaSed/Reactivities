using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class LostAddController : ControllerBase
    {
        private readonly DataContext _context;

        public LostAddController(DataContext context)
        {
            _context = context;
        }
        
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LostAdd>>> Get()
        {
             var lostadds = await _context.LostAdds.ToListAsync();
            return Ok(lostadds);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LostAdd>> Get(int id)
        {
            var lostadds = await _context.LostAdds.FindAsync(id);
            return Ok(lostadds);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
