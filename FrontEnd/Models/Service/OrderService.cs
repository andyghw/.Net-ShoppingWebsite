using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Assignment4.Models;
using Newtonsoft.Json;

namespace ShoppingWebsiteFront.Models.Service
{
    public class OrderService
    {
        public List<Order> GetOrders(int userId){
            string url = "http://localhost:63224/api/Order/GetOrder/"+userId;
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
            Debug.WriteLine(res);
            var orders = JsonConvert.DeserializeObject<List<Order>>(res);
            return orders;
        }

        public List<Item> GetOrderDetail(string orderId)
        {
            string url = "http://localhost:63224/api/Order/GetOrderDetail/" + orderId;
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
            var items = JsonConvert.DeserializeObject<List<Item>>(res);
            return items;
        }

        public void AddOrder(List<Item> items)
        {
            string url = "http://localhost:63224/api/Order/AddOrder";
            WebRequest request = WebRequest.Create(url);
            request.Method = "post";
            request.ContentType = "application/json; charset=UTF-8";
            var json = JsonConvert.SerializeObject(items);
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

        public void DeleteOrder(string orderId)
        {
            string url = "http://localhost:63224/api/Order/DeleteOrder/" + orderId;
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

        public List<Item> GetMostRecentOrder(int userId)
        {
            string url = "http://localhost:63224/api/Order/GetMostRecentOrder/" + userId;
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
                var items = JsonConvert.DeserializeObject<List<Item>>(res);
                return items;
            }
            else
            {
                return null;
            }
        }

        public void UpdateOrder(string orderId)
        {
            string url = "http://localhost:63224/api/Order/UpdateOrder/" + orderId;
            WebRequest request = WebRequest.Create(url);
            request.Method = "put";
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
        }
    }
}
