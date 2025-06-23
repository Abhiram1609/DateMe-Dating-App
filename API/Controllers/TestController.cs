using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController(DataContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetTest()
        {
            var TestUsers = await context.Users.ToListAsync();

            return TestUsers;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUser>> GetTest(int id)
        {
            var testUser = await context.Users.FindAsync(id);
            
            if (testUser == null) return NotFound();

            return testUser;
        }
    }
}
