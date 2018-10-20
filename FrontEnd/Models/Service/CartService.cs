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
    public class CartService
    {
        public List<Item> getCart(int id)
        {
            string url = "http://localhost:63224/api/Cart/GetCart/" + id;
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
                List<Item> items= JsonConvert.DeserializeObject<List<Item>>(res);
                return items;
            }
            else
            {
                return null;
            }
        }

        public bool AddCart(Item item)
        {
            string url = "http://localhost:63224/api/Cart/AddCartItem";
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            request.ContentType = "application/json; charset=UTF-8";
            var json = JsonConvert.SerializeObject(item);
            byte[] data = Encoding.UTF8.GetBytes(json);
            request.ContentLength = data.Length;
            Stream newStream = request.GetRequestStream();

            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();
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
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Check(Item item)
        {
            string url = "http://localhost:63224/api/Cart/CheckCartItem";
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            request.ContentType = "application/json; charset=UTF-8";
            var json = JsonConvert.SerializeObject(item);
            byte[] data = Encoding.UTF8.GetBytes(json);
            request.ContentLength = data.Length;
            Stream newStream = request.GetRequestStream();

            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();
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
            if (res.Equals("true"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateAddCart(Item item)
        {
            string url = "http://localhost:63224/api/Cart/UpdateAddCartItem";
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            request.ContentType = "application/json; charset=UTF-8";
            var json = JsonConvert.SerializeObject(item);
            byte[] data = Encoding.UTF8.GetBytes(json);
            request.ContentLength = data.Length;
            Stream newStream = request.GetRequestStream();

            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();
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
        }

        public void UpdateCart(Item item)
        {
            string url = "http://localhost:63224/api/Cart/UpdateCartItem";
            WebRequest request = WebRequest.Create(url);
            request.Method = "put";
            request.ContentType = "application/json; charset=UTF-8";
            var json = JsonConvert.SerializeObject(item);
            byte[] data = Encoding.UTF8.GetBytes(json);
            request.ContentLength = data.Length;
            Stream newStream = request.GetRequestStream();
            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();
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
        }

        public void DeleteCart(string id)
        {
            string url = "http://localhost:63224/api/Cart/DeleteCartItem/"+id;
            WebRequest request = WebRequest.Create(url);
            request.Method = "delete";
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
        }

        public void CleanCart(int id)
        {
            string url = "http://localhost:63224/api/Cart/CleanCart/" + id;
            WebRequest request = WebRequest.Create(url);
            request.Method = "delete";
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
        }
    }
}
