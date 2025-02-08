using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("78 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Joseph Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Macbook", "MC21", 2010.99, 1));
        order1.AddProduct(new Product("Mac Mouse", "MCM4", 53.50, 2));

        Address address2 = new Address("74 Stanley Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emma Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Ipad12", "IPMC1", 345.77, 2));
        order2.AddProduct(new Product("Cinema-Monitor", "MCM27", 400.00, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine("--------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}