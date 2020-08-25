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
    public class FoundAddController : ControllerBase
    {
        
        private readonly DataContext _context;

        public FoundAddController(DataContext context)
        {
            _context = context;
        }
        
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoundAdd>>> Get()
        {
             var foundadds = await _context.FoundAdds.ToListAsync();
            return Ok(foundadds);
        }

        // GET api/values/5
          [HttpGet("{id}")]
        public async Task<ActionResult<FoundAdd>> Get(int id)
        {
            var foundadds = await _context.FoundAdds.FindAsync(id);
            return Ok(foundadds);
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
