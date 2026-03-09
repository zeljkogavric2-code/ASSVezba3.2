
using System.Collections.Generic;
using LegacyOrderSystem.Helpers;
using LegacyOrderSystem.Models;
using LegacyOrderSystem.Repositories;

namespace LegacyOrderSystem.Services
{
    public class OrderService
    {
        private JsonOrderRepository repo = new JsonOrderRepository();
        private PricingService pricing = new PricingService();
        private EmailService email = new EmailService();

        public Order CreateOrder(string customer, List<OrderItem> items)
        {
            var order = new Order
            {
                Id = IdGenerator.NewId(),
                Customer = customer,
                Items = items,
                Created = DateTimeProvider.Now()
            };

            order.Total = pricing.Calculate(items);

            repo.Save(order);

            email.Send(customer, "Order created");

            return order;
        }

        public List<Order> GetAll()
        {
            return repo.GetAll();
        }
    }
}
