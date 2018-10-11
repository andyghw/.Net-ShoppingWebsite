using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4Api.Models;
using Assignment4Api.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Assignment4Api.Controllers
{
    [Route("api/[Controller]")]
    public class OrderController : Controller
    {
        private readonly OrderService OS;

        public OrderController(OrderService os)
        {
            OS = os;
        }

        [HttpPost]
        [Route("addOrder")]
        public async Task AddOrder([FromBody]List<Item> orderItems)
        {
            User user = new User
            {
                Id = 1,
                Username = "andyghw",
                Password = "19950116",
                Email = "guo.hanw@husky.neu.edu",
                Orders = new List<Order>()
            };
            await OS.AddOrder(orderItems, user);
        }

        [HttpDelete]
        [Route("deleteOrder/{orderId}")]
        public async Task DeleteOrder(int orderId)
        {
            User user = new User
            {
                Id = 1,
                Username = "andyghw",
                Password = "19950116",
                Email = "guo.hanw@husky.neu.edu",
                Orders = new List<Order>()
            };
            await OS.DeleteOrder(orderId);
        }
    }
}