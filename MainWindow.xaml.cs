
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using LegacyOrderSystem.Models;
using LegacyOrderSystem.Services;

namespace LegacyOrderSystem
{
    public partial class MainWindow : Window
    {
        private List<OrderItem> items = new List<OrderItem>();
        private OrderService orderService = new OrderService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            var item = new OrderItem
            {
                Product = txtProduct.Text,
                Price = decimal.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQty.Text)
            };

            items.Add(item);
        }

        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            var order = orderService.CreateOrder(txtCustomer.Text, items);

            lstOrders.ItemsSource = null;
            lstOrders.ItemsSource = orderService.GetAll()
                .Select(o => $"{o.Customer} | {o.Total}");

            items = new List<OrderItem>();
        }
    }
}
