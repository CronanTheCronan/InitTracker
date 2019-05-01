using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InitTrackerApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InitTrackerApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CreaturesController : ControllerBase
    {
        private readonly DataContext _context;
        public CreaturesController(DataContext context)
        {
            _context = context;

        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetCreatures()
        {
            var creatures = await _context.Creatures.ToListAsync();

            return Ok(creatures);
        }

        [AllowAnonymous]
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCreature(int id)
        {
            var creature = await _context.Creatures.FirstOrDefaultAsync(x => x.Id == id);
            
            return Ok(creature);
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