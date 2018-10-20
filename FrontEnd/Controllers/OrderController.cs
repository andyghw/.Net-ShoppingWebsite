using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingWebsiteFront.Models.Service;

namespace ShoppingWebsiteFront.Controllers
{
    [Route("Order")]
    public class OrderController : Controller
    {
        private readonly CartService CS;
        private readonly OrderService OS;

        public OrderController(CartService cs, OrderService os)
        {
            CS = cs;
            OS = os;
        }

        [Route("")]
        public IActionResult OrdersInfo()
        {
            ViewBag.Orders = OS.GetOrders((int)HttpContext.Session.GetInt32("userId"));
            return View();
        }

        [Route("OrderDetail/{orderId}")]
        public IActionResult OrderDetail(string orderId)
        {
            ViewBag.Items = OS.GetOrderDetail(orderId);
            ViewBag.OrderId = orderId;
            return View();
        }

        [Route("GetMostRecentOrder")]
        public IActionResult MostRecentOrder()
        {
            ViewBag.Items = OS.GetMostRecentOrder((int)HttpContext.Session.GetInt32("userId"));
            return View();
        }

       [HttpPost]
       [Route("AddOrder")]
       public IActionResult AddOrder([FromBody]List<Item> items)
        {
            CS.CleanCart((int)HttpContext.Session.GetInt32("userId"));
            OS.AddOrder(items);
            return new OkObjectResult(true);
        }

        [HttpDelete]
        [Route("DeleteOrder/{orderId}")]
        public IActionResult DeleteOrder(string orderId)
        {
            OS.DeleteOrder(orderId);
            return new OkObjectResult(true);
        }

        [HttpPut]
        [Route("PayOrder")]
        public IActionResult PayOrder(string orderId)
        {
            OS.UpdateOrder(orderId);
            return Redirect("/");
        }
    }
}