using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4Api.Models;
using Assignment4Api.Models.Services;
using Assignment4Api.MySqlConnector;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4Api.Controllers
{
    [Route("api/[Controller]")]
    public class CartController : Controller
    {
        private readonly AppDb Db;
        private readonly CartService CS;

        public CartController(AppDb db, CartService cs)
        {
            Db = db;
            CS = cs;
        }

        [HttpPost]
        [Route("AddCartItem")]
        public async Task AddCart([FromBody]Item item)
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
                await CS.AddCartItem(user,item);
            }
        }

        [HttpDelete]
        [Route("DeleteCartItem/{cartItemId}")]
        public async Task DeleteCart(int cartItemId)
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
                await CS.DeleteCartItem(cartItemId);
            }
        }

        [HttpPut]
        [Route("UpdateCartItem")]
        public async Task UpdateCart([FromBody]Item cartItem)
        {
            using (Db)
            {
                await Db.Connection.OpenAsync();
                await CS.UpdateCartItem(cartItem);
            }
        }

        [Route("GetCart")]
        public async Task<IActionResult> GetCartContent()
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
                var result=await CS.GetCartContentAsync(user);
                if (result == null)
                {
                    return new NotFoundResult();
                }
                return new OkObjectResult(result);
            }
        }
    }
}