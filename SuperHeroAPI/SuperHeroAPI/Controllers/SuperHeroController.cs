using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> heros = new List<SuperHero>
        {
            new SuperHero { Id = 1,
            FirstName = "Thor",
            LastName = "Ragnarok",
            Name =  "Chris",
            Place = "Azgard"

            },

             new SuperHero { Id = 2,
            FirstName = "Tony",
            LastName = "Stark",
            Name =  "Ironman",
            Place = "USA"

            }
        };

    [HttpGet]
        public async Task<ActionResult<SuperHero>> Get()
        {
            return Ok(heros);
        }

        public async Task<ActionResult<SuperHero>> Get(int id)
        {
            var herp = heros.Find(h => h.Id == id);
            return BadRequest("Hero Not Found");
        }
        [HttpPost]
        public async Task<ActionResult<SuperHero>> AddHero(SuperHero hero)
        {
            heros.Add(hero);
            return Ok(heros);
        }
    }
}
