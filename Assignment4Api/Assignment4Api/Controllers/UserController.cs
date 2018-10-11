using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4Api.Models;
using Assignment4Api.MySqlConnector;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4Api.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly UserService US;

        public UserController(UserService us)
        {
            US = us;
        }

        [HttpPost]
        [Route("findUser")]
        public async Task<IActionResult> Login(string email,string password)
        {
            using (var db = new AppDb())
            {
                await db.Connection.OpenAsync();
                var result = await US.FindOneAsync(email,password);
                return new OkObjectResult(result);
            }
        }

        [HttpPost]
        [Route("register")]
        public async void Register(string email, string username, string password)
        {
            using (var db = new AppDb())
            {
                await db.Connection.OpenAsync();
                var user=new User(db)
                {
                    Email=email,
                    Username=username,
                    Password=password
                };
                await user.InsertAsync();
            }
        }
    }
}