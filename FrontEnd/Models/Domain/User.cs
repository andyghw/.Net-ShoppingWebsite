using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Assignment4.Models
{
    public class User
    {
        public int Id{ get;set;}
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
        public List<Item> Cart { get; set; }


        public User() {
            Orders = new List<Order>();
            Cart = new List<Item>();
        }
    }
}
