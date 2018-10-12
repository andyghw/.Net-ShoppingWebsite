using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4Api.MySqlConnector;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Assignment4Api.Models
{
    public class ProductService
    {
        [JsonIgnore]
        public readonly AppDb Db;

        public ProductService(AppDb db)
        {
            Db = db;
        }

        public async Task<List<Product>> SearchByKeyword(string str)
        {
            var cmd = Db.Connection.CreateCommand() as MySqlCommand;
            string[] keywords = str.Split(" ");
            StringBuilder sb = new StringBuilder(@"SELECT name,price,url,text,type,img,products.id FROM products INNER JOIN imgs ON products.id=imgs.productId WHERE ");
            for (int i = 0; i < keywords.Length; i++)
            {
                if (i == keywords.Length - 1)
                {
                    sb.Append(@"products.name LIKE @keyword" + i);
                }
                else
                {
                    sb.Append(@"products.name LIKE @keyword" + i + " AND ");
                }
            }
            var s = sb.ToString();
            Debug.WriteLine(s);
            cmd.CommandText = @s;
            for (int i = 0; i < keywords.Length; i++)
            {
                cmd.Parameters.AddWithValue("@keyword" + i, "%" + keywords[i] + "%");
            }
            var result = await ReadAllAsync(await cmd.ExecuteReaderAsync());
            return result;
        }

        private async Task<List<Product>> ReadAllAsync(DbDataReader reader)
        {
            var products = new List<Product>();
            List<string> names = new List<string>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var Name = await reader.GetFieldValueAsync<string>(0);
                    if (names.Contains(Name))
                    {
                        foreach(var product in products)
                        {
                            if (product.name.Equals(Name))
                            {
                                product.imgs.Add(await reader.GetFieldValueAsync<string>(5));
                                break;
                            }
                        }
                    }
                    else
                    {
                        var product = new Product()
                        {
                            name = Name,
                            price = await reader.GetFieldValueAsync<double>(1),
                            url = await reader.GetFieldValueAsync<string>(2),
                            text = await reader.GetFieldValueAsync<string>(3),
                            type = await reader.GetFieldValueAsync<string>(4),
                            imgs = new List<string>(),
                            id= await reader.GetFieldValueAsync<int>(6)
                        };
                        product.imgs.Add(await reader.GetFieldValueAsync<string>(5));
                        products.Add(product);
                    }
                }
            }
            return products;
        }
    }
}
