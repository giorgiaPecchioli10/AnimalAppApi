﻿using Microsoft.AspNetCore.Mvc;

namespace AnimalAppApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // GET: api/<AnimalsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AnimalsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AnimalsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

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
