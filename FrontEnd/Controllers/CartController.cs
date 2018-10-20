using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingWebsiteFront.Models.Service;

namespace ShoppingWebsiteFront.Controllers
{
    [Route("Cart")]
    public class CartController : Controller
    {
        private readonly CartService CS;

        public CartController(CartService cs)
        {
            CS = cs;
        }

        [HttpPost]
        [Route("AddCart")]
        public IActionResult AddCart([FromBody]Item item)
        {
            if (HttpContext.Session.GetInt32("userId") == null)
            {
                return new OkObjectResult(false);
            }
            item.UserId = (int)HttpContext.Session.GetInt32("userId");
            bool existed = CS.Check(item);
            if (existed)
            {
                CS.UpdateAddCart(item);
                return new OkObjectResult(true);
            }
            else
            {
                bool success = CS.AddCart(item);
                if (success)
                {
                    return new OkObjectResult(true);
                }
                else
                {
                    return new OkObjectResult(false);
                }
            }
        }

        [Route("")]
        public IActionResult ViewCart()
        {
            var userId = (int)HttpContext.Session.GetInt32("userId");
            List<Item> items = CS.getCart(userId);
            ViewBag.Items = items;
            ViewBag.ItemsJson = new HtmlString(JsonConvert.SerializeObject(items));
            return View();
        }

        [HttpPut]
        [Route("UpdateCart")]
        public IActionResult UpdateCart([FromBody]Item item)
        {
            CS.UpdateCart(item);
            return new OkObjectResult(true);
        }

        [HttpDelete]
        [Route("DeleteCart/{id}")]
        public IActionResult DeleteCart(string id)
        {
            CS.DeleteCart(id);
            return new OkObjectResult(true);
        }
    }
}