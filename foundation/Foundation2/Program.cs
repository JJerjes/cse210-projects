using System;

namespace OnlineProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", "p001", 800, 2);
            Product product2 = new Product("Mouse", "p002", 22, 4);
            Product product3 = new Product("Keyboard", "p003", 40, 3);

            Address address1 = new Address("334 Lisboa fr", "California", "CA", "United States");
            Address address2 = new Address("765 Ontoria", "Toronto", "ON", "Canada");

            Customer customer1 = new Customer("Carlin Portilla", address1);
            Customer customer2 = new Customer("Jhon Lenon", address2);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            Console.WriteLine("Order1: ");
            Console.WriteLine(order1.GetLabel());
            Console.WriteLine(order1.GetShip());
            Console.WriteLine($"Total Price: ${order1.TotalOrder()}\n");

            Console.WriteLine("Order2: ");
            Console.WriteLine(order2.GetLabel());
            Console.WriteLine(order2.GetShip());
            Console.WriteLine($"Total Price: ${order2.TotalOrder()}");
        }
    }
}
