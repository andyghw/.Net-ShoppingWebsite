using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4Api.MySqlConnector;
using Newtonsoft.Json;

namespace Assignment4Api.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Num { get; set; }
        public double Price { get; set; }
        public string Img { get; set; }
        public int OrderId { get; set; }
        public long UserId { get; set; }
    }
}
