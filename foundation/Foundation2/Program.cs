using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Laptop", "P001", 1000, 1);
        Product product2 = new Product("Mouse", "P002", 20, 2);
        Product product3 = new Product("Keyboard", "P003", 50, 1);

        Product product4 = new Product("Monitor", "P004", 300, 1);
        Product product5 = new Product("Headset", "P005", 80, 1);

        // Create customer addresses
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2, product3 }, customer1);
        Order order2 = new Order(new List<Product> { product4, product5 }, customer2);

        // Display details for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // Display details for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}
