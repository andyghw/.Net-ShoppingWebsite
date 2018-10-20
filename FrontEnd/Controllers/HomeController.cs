using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4.Models;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            string url = "http://localhost:63224/api/Product/FindLastThree";
            WebRequest request = WebRequest.Create(url);
            request.Method = "get";
            string res = string.Empty;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                res = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            var products = JsonConvert.DeserializeObject<List<Product>>(res);
            ViewBag.Products = products;
            if (HttpContext.Session.GetString("username") == null)
            {
                HttpContext.Session.SetString("username", "");
            }
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }
    }
}
