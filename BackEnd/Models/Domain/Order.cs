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
        public List<Item> OrderItem { get; set; }
        [JsonIgnore]
        public AppDb Db { get; set; }

        public Order(List<Item> orderItems,AppDb db=null)
        {
            Db = db;
            OrderItem = orderItems;
            Created_at = DateTime.Now;
        }
    }
}
