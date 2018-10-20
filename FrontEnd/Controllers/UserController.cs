using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Assignment4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ShoppingWebsiteFront.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        [Route("")]
        public IActionResult UserInfo()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            ViewBag.Email = HttpContext.Session.GetString("email");
            ViewBag.Password = HttpContext.Session.GetString("password");
            return View();
        }

        [HttpPost]
        [Route("UpdateAccount")]
        public IActionResult UpdateAccount(string username,string password,string email)
        {
            string url = "http://localhost:63224/api/User/UpdateAccount?email="+email+"&password="+password+"&username="+username;
            WebRequest request = WebRequest.Create(url);
            request.Method = "put";
            string res = string.Empty;
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Redirect("/");
            }
            else
            {
                return Redirect("/User");
            }
        }

        [Route("RegisterPage")]
        public IActionResult RegisterPage()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(string email,string password,string username)
        {
            string url = "http://localhost:63224/api/User/Register?email="+email+"&password="+password+"&username="+username;
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            string res = string.Empty;
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            if (response.StatusCode==HttpStatusCode.OK)
            {
                return Redirect("/User/LoginPage");
            }
            else
            {
                return Redirect("/User/RegisterPage");
            }
        }

        [Route("LoginPage")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(string email, string password)
        {
            string url = "http://localhost:63224/api/User/Login?email=" + email + "&password=" + password;
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            string res = string.Empty;
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                res = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            if (response == null)
            {
                return Redirect("/User/LoginPage");
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var user = JsonConvert.DeserializeObject<User>(res);
                HttpContext.Session.SetInt32("userId", user.Id);
                HttpContext.Session.SetString("username", user.Username);
                HttpContext.Session.SetString("password", user.Password);
                HttpContext.Session.SetString("email", user.Email);
                Debug.WriteLine(HttpContext.Session.GetString("username"));
                return Redirect("/");
            }
            else
            {
                return Redirect("/User/LoginPage");
            }
        }
    }
}