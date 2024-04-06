//Encapsulation with Online Ordering:
using System;

class Program
{
    static void Main(string[] args)
    {
        //Customers
        Customer customer1 = new Customer ("Michael Smith", "123 Main St","Austin", "TX", "USA");
        Customer customer2 = new Customer ("Maria Lopez", "987 Silver Rd", "Montgomery", "AL", "USA");
        Customer customer3 = new Customer ("Julia Martinez", "54 S 63W", "Mexico City", "Mexico City", "Mexico" );

        //Products
        Product product1 = new Product("Laptop", "P001", 250.00m, 1);
        Product product2 = new Product("Pencil Sharpener", "P002", 9.99m, 1);
        Product product3 = new Product("Computer", "P003", 400.25m, 1);

        //Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product3);

        Console.WriteLine("Order 1: ");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2: ");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 3: ");
        Console.WriteLine(order3.GeneratePackingLabel());
        Console.WriteLine(order3.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order3.CalculateTotalCost()}");
    }
}