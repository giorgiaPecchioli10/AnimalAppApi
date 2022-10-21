using AnimalAppApi.Models;
using AnimalAppApi.Service;
using AnimalAppApi.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AnimalAppApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private IService _animalService = new ServiceAnimal();

        [HttpPost]
        public IActionResult Post([FromBody] PostAnimalModel postAnimalModel)
        {
            var animalToAdd = _animalService.Create(postAnimalModel);
            return Created("",animalToAdd);
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var allAnimal = _animalService.GetAllAnimal();
            if(allAnimal == null)
                return NotFound("Animale non trovato");
            return Ok(allAnimal);
        }




        // GET: api/<AnimalsController>


        // GET api/<AnimalsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AnimalsController>
       

        // PUT api/<AnimalsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnimalsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
