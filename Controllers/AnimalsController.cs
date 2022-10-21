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

        [HttpGet("{animalId}")]
        public IActionResult GetById(int animalId)
        {

            var animal = _animalService.GetDetail(animalId);
            if (animal == null)
                return NoContent();
            return Ok(animal);
        }

        [HttpDelete("{animalId}")]
        public IActionResult Delete(int animalId)
        {
            var animalToDelete=_animalService.Delete(animalId);
            if (animalToDelete == null)
                return NoContent();
            return Ok();
        }

        // GET: api/<AnimalsController>


        // GET api/<AnimalsController>/5

        // POST api/<AnimalsController>


        // PUT api/<AnimalsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnimalsController>/5
        
    }
}
