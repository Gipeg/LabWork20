using LabWork20.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabWork20.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        List<Category> Categories = new List<Category>
        {
             new Category{Id = 1, Name = "головоломка", Description = "описание жанра головоломка"},
             new Category{Id = 2, Name = "платформер", Description = "описание жанра платформер"},
             new Category{Id = 3, Name = "RPG", Description = "описание жанра RPG"},
             new Category{Id = 4, Name = "аркада", Description = "описание жанра аркада"}
        };


        // GET: api/<CategoriesController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return Categories;
        }

        [HttpGet("{name}")]
        public IEnumerable<Category> Get(string name)
        {
            return Categories.Where(category => category.Name == name);
        }


        // GET api/<CategoriesController>/5
        [HttpGet("{id:int}")]
        public Category Get(int id)
        {
            return Categories.FirstOrDefault(category => category.Id == id);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var category = Categories.FirstOrDefault(category => category.Id == id);
            Categories.Remove(category);
        }
    }
}
