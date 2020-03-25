using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using WebApiTest.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public static List<Person> _people = new List<Person>()
        {
            new Person { Name = "Eric", Age = 31, ConfirmEmail = "ericperezvillar@gmail.com", Email = "ericperezvillar@gmail.com", UserName = "ericperezvillar", Id = 1 }
        };


        /// <summary>
        /// Get the full list of people
        /// </summary> 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> ListAllPeople()
        {
            var result = await Task.FromResult(_people.ToList()); 
            if (result.Any())
            {
                return Ok(result);
            }
            return BadRequest();
        }

        /// <summary>
        /// Insert a new person to the list of people
        /// </summary> 
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Person>>> InsertPerson([FromBody] Person person)
        {
            var newId = GetLatestIdFromList();
            person.Id = newId;

            _people.Add(person);
            var result = await Task.FromResult(_people.ToList());

            if (result.Count > 1)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        #region Private Methods
        private int GetLatestIdFromList()
        {
            return _people.Max(x => x.Id) + 1;
        }
        #endregion

    }
}