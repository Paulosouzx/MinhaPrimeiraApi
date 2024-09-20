using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinhaPrimeiraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            List<UserModel> users = new List<UserModel>();

            users.Add(new UserModel() { ID = 1, Name = "Paulo", Email = "paulo@gmail.com" });

            return users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserModel Get(int id)
        {
            UserModel user = new UserModel() { ID = 1, Name = "Paulo", Email = "paulo@gmail.com" };

            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        //frombody = os dados do user vao vir do corpo da api
        public void Post([FromBody] UserModel user)
        {
            
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserModel user)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
