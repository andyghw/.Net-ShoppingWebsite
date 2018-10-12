using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4Api.Models;
using Assignment4Api.Models.Services;
using Assignment4Api.MySqlConnector;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Assignment4Api.Controllers
{
    [Route("api/[Controller]")]
    public class OrderController : Controller
    {
        private readonly OrderService OS;
        private readonly AppDb Db;

        public OrderController(OrderService os,AppDb db)
        {
            OS = os;
            Db = db;
        }

        [HttpPost]
        [Route("AddOrder")]
        public async Task AddOrder([FromBody]List<Item> orderItems)
        {
            using (Db)
            {
                await Db.Connection.OpenAsync();
                User user = new User(Db)
                {
                    Id = 1,
                    Username = "andyghw",
                    Password = "19950116",
                    Email = "guo.hanw@husky.neu.edu"
                };
                await OS.AddOrder(orderItems, user);
            }
        }

        [HttpDelete]
        [Route("DeleteOrder/{orderId}")]
        public async Task DeleteOrder(int orderId)
        {
            using (Db)
            {
                await Db.Connection.OpenAsync();
                User user = new User
                {
                    Id = 1,
                    Username = "andyghw",
                    Password = "19950116",
                    Email = "guo.hanw@husky.neu.edu"
                };
                await OS.DeleteOrder(orderId);
            }
        }
    }
}