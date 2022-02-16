using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var heros = new List<SuperHero>
            {
                new SuperHero { Id = 1,
                    FirstName = "Thor",
                    LastName = "Ragnarok",
                    Name =  "Chris",
                    Place = "Azgard"}
            };

            return Ok(heros);
        }
    }
}
