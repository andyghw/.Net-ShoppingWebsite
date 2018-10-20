using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4Api.MySqlConnector;
using Newtonsoft.Json;

namespace Assignment4Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Created_at { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public AppDb Db { get; set; }

        public Order() { }

        public Order(List<Item> orderItems,AppDb db=null)
        {
            Db = db;
            Created_at = DateTime.Now;
        }
    }
}
