using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment4Api.MySqlConnector;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Assignment4Api.Models.Services
{
    public class OrderService
    {
        [JsonIgnore]
        public AppDb Db { get; set; }

        public OrderService(AppDb db = null)
        {
            Db = db;
        }

        public async Task AddOrder(List<Item> orderItems, User user)
        {
            Order order = new Order(orderItems);
            MySqlConnection conn = Db.Connection;
            var cmd = conn.CreateCommand() as MySqlCommand;
            //Transaction
            using (IDbTransaction tran = conn.BeginTransaction())
            {
                try
                {
                    // your code
                    cmd.CommandText = @"INSERT INTO orders (userId,created_at) VALUES (@userId,@created_at)";
                    cmd.Parameters.AddWithValue("@userId", user.Id);
                    cmd.Parameters.AddWithValue("@created_at", order.Created_at);
                    await cmd.ExecuteNonQueryAsync();
                    long orderId = cmd.LastInsertedId;
                    int i = 0;
                    foreach (var item in orderItems)
                    {
                        cmd.CommandText = @"INSERT INTO orderItems (orderId,title,num,price,img) VALUES (@orderId" + i + ",@title" + i + ",@num" + i + ",@price" + i + ",@img" + i + ")";
                        cmd.Parameters.AddWithValue("@orderId" + i, orderId);
                        cmd.Parameters.AddWithValue("@title" + i, item.Title);
                        cmd.Parameters.AddWithValue("@num" + i, item.Num);
                        cmd.Parameters.AddWithValue("@price" + i, item.Price);
                        cmd.Parameters.AddWithValue("@img" + i, item.Img);
                        await cmd.ExecuteNonQueryAsync();
                        i++;
                    }
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        public async Task DeleteOrder(int orderId)
        {
            MySqlConnection conn = Db.Connection;
            var cmd = conn.CreateCommand() as MySqlCommand;
            //Transaction
            using (IDbTransaction tran = conn.BeginTransaction())
            {
                try
                {
                    // your code
                    cmd.CommandText = @"DELETE FROM orders WHERE id=@orderId";
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    await cmd.ExecuteNonQueryAsync();
                    cmd.CommandText = @"DELETE FROM orderitems WHERE orderId=@orderId2";
                    cmd.Parameters.AddWithValue("@orderId2", orderId);
                    await cmd.ExecuteNonQueryAsync();
                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
