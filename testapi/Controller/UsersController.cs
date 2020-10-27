using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testapi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testapi.Controller
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _users;

        public UsersController(IUsers users)
        {
            _users = users;
        }
        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<Users>> Get()
        {
            return _users.GetAll().ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            return _users.GetUser(id);
        }

        // POST api/<controller>
        [HttpPost("add")]
        public ActionResult<Users> Post([FromBody]Users users)
        {
            return _users.AddUser(users);
        }

        // PUT api/<controller>/5
        [HttpPut("update/{id}")]
        public ActionResult<Users> Put(int id, [FromBody]Users users)
        {
            return _users.UpdateUser(id, users);
        }

        // DELETE api/<controller>/5
        [HttpDelete("delete/{id}")]
        public ActionResult<Users> Delete(int id)
        {
            return _users.DeleteUser(id);
        }
    }
}
