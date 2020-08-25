using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        
        private readonly DataContext _context;

        public ProfileController(DataContext context)
        {
            _context = context;
        }
        
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profile>>> Get()
        {
             var profiles = await _context.Profiles.ToListAsync();
            return Ok(profiles);
        }

        // GET api/values/5
           [HttpGet("{id}")]
        public async Task<ActionResult<Profile>> Get(int id)
        {
            var profile = await _context.Profiles.FindAsync(id);
            return Ok(profile);
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

