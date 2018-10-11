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
    public class ProductController : Controller
    {
        private readonly ProductService PS;

        public ProductController(ProductService ps)
        {
            PS=ps;
        }

        [HttpGet]
        [Route("Search")]
        public async Task<IActionResult> SearchProducts(string keywords)
        {
            using (var db = new AppDb())
            {
                await db.Connection.OpenAsync();
                var result = await PS.SearchByKeyword(keywords);
                return new OkObjectResult(result);
            }
        }
    }
}