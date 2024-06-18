using LabWork20.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabWork20.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {

        List<Game> Games = new List<Game>
        {
            new Game{IdGame = 1, Name = "Tetris", Category = "puzzle", Price = 150},
            new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "platformer", Price = 10},
            new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "arcade", Price = 300},
            new Game{IdGame = 4, Name = "Arkanoid", Category = "arcade", Price = 400},
            new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "platformer", Price = 1000},
            new Game{IdGame = 6, Name = "Tetris2", Category = "puzzle", Price = 150},
            new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "platformer", Price = 10},
            new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Category = "arcade", Price = 300},
            new Game{IdGame = 9, Name = "Arkanoid2", Category = "arcade", Price = 400},
            new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Category = "platformer", Price = 1000},
        };

        // GET: api/<GamesController>
        [HttpGet]
        public IEnumerable<Game> Get(int pageNumber = 0, int pageSize = 10)
        {
            return Games.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        [HttpGet("{category:alpha}")]
        public IEnumerable<Game> Get(string category)
        {
            return Games.Where(game => game.Category == category);
        }

        // GET api/<GamesController>/5
        [HttpGet("{id:int}")]
        public Game Get(int id)
        {
            return Games.FirstOrDefault(game => game.IdGame == id);
        }

        // POST api/<GamesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GamesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GamesController>/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            var game = Games.FirstOrDefault(game => game.IdGame == id);
            Games.Remove(game);
        }
    }
}
