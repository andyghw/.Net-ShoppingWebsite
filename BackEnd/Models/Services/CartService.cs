using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Assignment4Api.MySqlConnector;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Assignment4Api.Models.Services
{
    public class CartService
    {
        [JsonIgnore]
        public AppDb Db { get; set; }

        public CartService(AppDb db)
        {
            Db = db;
        }

        public async Task AddCartItem(User user, Item cartItem)
        {
            MySqlConnection conn = Db.Connection;
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"INSERT INTO cartItems (userId,title,num,price,img) VALUES (@userId,@title,@num,@price,@img)";
            cmd.Parameters.AddWithValue("@userId", user.Id);
            cmd.Parameters.AddWithValue("@title", cartItem.Title);
            cmd.Parameters.AddWithValue("@num", cartItem.Num);
            cmd.Parameters.AddWithValue("@price", cartItem.Price);
            cmd.Parameters.AddWithValue("@img", cartItem.Img);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteCartItem(int cartItemId)
        {
            MySqlConnection conn = Db.Connection;
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM cartItems WHERE id=@cartItemId";
            cmd.Parameters.AddWithValue("@cartItemId", cartItemId);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task UpdateCartItem(Item cartItem)
        {
            MySqlConnection conn = Db.Connection;
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"UPDATE cartItems SET num = @num WHERE id=@id";
            cmd.Parameters.AddWithValue("@num", cartItem.Num);
            cmd.Parameters.AddWithValue("@id",cartItem.Id);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<Item>> GetCartContentAsync(User user)
        {
            var cmd = Db.Connection.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM cartItems WHERE userId=@userId";
            cmd.Parameters.AddWithValue("@userId",user.Id);
            var result = await ReadAllAsync(await cmd.ExecuteReaderAsync());
            return result;
        }

        private async Task<List<Item>> ReadAllAsync(DbDataReader reader)
        {
            var cartItems = new List<Item>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var item = new Item()
                    {
                        Id = await reader.GetFieldValueAsync<int>(0),
                        Title = await reader.GetFieldValueAsync<string>(2),
                        Num = await reader.GetFieldValueAsync<int>(3),
                        Price = await reader.GetFieldValueAsync<double>(4),
                        Img = await reader.GetFieldValueAsync<string>(5)
                    };
                    cartItems.Add(item);
                }
            }
            return cartItems;
        }
    }
}

