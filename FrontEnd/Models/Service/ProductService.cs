using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Assignment4.Models;
using Newtonsoft.Json;

namespace ShoppingWebsiteFront.Models.Service
{
    public class ProductService
    {
        public List<Product> Search(string keywords)
        {
            if (keywords == null || keywords.Trim().Equals(""))
            {
                keywords = "a";
            }
            string url = "http://localhost:63224/api/Product/Search?keywords=" + keywords;
            WebRequest request = WebRequest.Create(url);
            request.Method = "get";
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
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var products= JsonConvert.DeserializeObject<List<Product>>(res);
                return products;
            }
            else
            {
                return null;
            }
        }

        public Product FindById(string id)
        {
            string url = "http://localhost:63224/api/Product/FindById/"+id;
            WebRequest request = WebRequest.Create(url);
            request.Method = "get";
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
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var product = JsonConvert.DeserializeObject<Product>(res);
                return product;
            }
            else
            {
                return null;
            }
        }
    }
}
