
using System.Collections.Generic;
using System.Linq;
using LegacyOrderSystem.Models;

namespace LegacyOrderSystem.Services
{
    public class PricingService
    {
        public decimal Calculate(List<OrderItem> items)
        {
            return items.Sum(i => i.Price * i.Quantity);
        }
    }
}
