using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Assignment4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingWebsiteFront.Models.Service;

namespace ShoppingWebsiteFront.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly ProductService PS;

        public ProductController(ProductService ps)
        {
            PS = ps;
        }

        [HttpPost]
        [Route("Search")]
        public IActionResult Search(string keywords)
        {
            List<Product> products=PS.Search(keywords);
            ViewBag.Products = products;
            return View();
        }

        [Route("ProductDetail/{id}")]
        public IActionResult ProductDetail(string id)
        {
            Product product = PS.FindById(id);
            ViewBag.Product = product;
            return View();
        }
    }
}