using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Assignment4.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price{get; set;}
        public string Url { get; set; }
        public string Text { get; set; }
        public List<string> Imgs { get; set; }
        public string Type { get; set; }
    }
}
