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
        private readonly AppDb Db;

        public ProductController(ProductService ps,AppDb db)
        {
            PS = ps;
            Db = db;
        }

        [HttpGet]
        [Route("Search")]
        public async Task<IActionResult> SearchProducts(string keywords)
        {
            using(Db)
            {
                await Db.Connection.OpenAsync();
                var result = await PS.SearchByKeyword(keywords);
                if (result == null)
                {
                    return new NotFoundResult();
                }
                return new OkObjectResult(result);
            }
        }
    }
}