using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Covid_Api_Project.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CovidController : ControllerBase
    {
        // GET: api/<CovidController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CovidController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CovidController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CovidController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CovidController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
