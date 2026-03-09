
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using LegacyOrderSystem.Models;

namespace LegacyOrderSystem.Repositories
{
    public class JsonOrderRepository
    {
        private string path = "orders.json";

        public void Save(Order order)
        {
            var list = GetAll();
            list.Add(order);
            File.WriteAllText(path, JsonSerializer.Serialize(list));
        }

        public List<Order> GetAll()
        {
            if (!File.Exists(path)) return new List<Order>();
            return JsonSerializer.Deserialize<List<Order>>(File.ReadAllText(path));
        }
    }
}
