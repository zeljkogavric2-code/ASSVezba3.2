
using System;
using System.Collections.Generic;

namespace LegacyOrderSystem.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }
    }
}
