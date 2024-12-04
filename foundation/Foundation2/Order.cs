using System;
using System.Collections.Generic;

namespace OnlineProducts
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double TotalOrder()
        {
            double total =0;
            foreach (var product in products)
            {
                total += product.TotalCost();
            }

            double shipCost = customer.InUSA() ? 5 : 35;
            total += shipCost;
            return total;
        }

        public string GetLabel()
        {
            string label = "Packging label:\n";
            foreach (var product in products)
            {
                label += product.GetProduct() + "\n";
            }
            return label;
        }

        public string GetShip()
        {
            return $"Shipping Label:\n{customer.GetCustomer()}";
        }

        public Customer OrderCustomer => customer;
    }
}