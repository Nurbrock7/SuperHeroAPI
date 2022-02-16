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
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(heros);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> Get(int id)
        {
            var hero = heros.Find(h => h.Id == id);
            if (heros == null)
                return BadRequest("Hero Not Found");
            return Ok(heros);
        }
        [HttpPost]
        public async Task<ActionResult<SuperHero>> AddHero(SuperHero hero)
        {
            heros.Add(hero);
            return Ok(heros);
        }
        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request)
        {
            var hero = heros.Find(h => h.Id == request.Id);
            if (heros == null)
                return BadRequest("Hero Not Found");

            hero.Name = request.Name;
            hero.Place = request.Place;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.LastName = request.LastName;

            return Ok(heros);

        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var hero = heros.Find(h => h.Id == id);
            if (heros == null)
                return BadRequest("Hero Not Found");

            heros.Remove(hero);
            return Ok(heros);
        }

    }
}
