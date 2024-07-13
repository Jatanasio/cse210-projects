using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Widget", "W123", 3.00, 5);
        Product product2 = new Product("Gadget", "G456", 10.00, 2);
        Product product3 = new Product("Doodad", "D789", 7.50, 4);
        Product product4 = new Product("Thingamajig", "T012", 15.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}