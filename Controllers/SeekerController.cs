using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeekHelpServer.Models;

namespace SeekHelpServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeekerController : ControllerBase
    {
        private SeekerModel[] seekers = 
        {
            new SeekerModel{Firstname = "Frederik", Lastname = "hjorth", Id = 0 },
            new SeekerModel{Firstname = "Bob", Lastname = "Hansen", Id = 1}
        };

        // GET: api/Seeker
        [HttpGet]
        public IEnumerable<SeekerModel> Get()
        {
            return seekers;
        }

        // GET: api/Seeker/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var product = seekers.FirstOrDefault((p) => p.Id == id);
            if(product == null)
            {
                return NotFound("This Seeker doesnt exist");
            }
            return Ok(product);
        }

        // POST: api/Seeker
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterStudentModel model )
        {
            if (ModelState.IsValid)
            {
                var user = new SeekerModel
                {
                    Firstname = model.FirstName,
                    Lastname = model.LastName
                };
                
                var created = new JsonResult("user created") {StatusCode = 201};
                return Ok(created);
            }

            return null;
        }

        // PUT: api/Seeker/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
