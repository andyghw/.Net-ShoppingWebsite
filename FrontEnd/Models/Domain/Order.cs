using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Assignment4.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Created_at { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
    }
}
