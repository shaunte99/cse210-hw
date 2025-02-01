using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Mandela Avenue", "Brooklyn", "New York", "United States");
        Address address2 = new Address("456 Mbeki Street", "Manhattan", "New York", "United States");
        
        Customer customer1 = new Customer("Thabo Dlamini", address1);
        Customer customer2 = new Customer("Zanele Khumalo", address2);
        
        Product product1 = new Product("Jordan 1s", 101, 199.99, 1);
        Product product2 = new Product("Volkano Headsets", 102, 299.99, 2);
        Product product3 = new Product("High rise jean", 103, 89.99, 3);
        Product product4 = new Product("Glitter Jacket", 104, 149.50, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost for Order 1: ${order1.CalculateOrderTotal():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost for Order 2: ${order2.CalculateOrderTotal():F2}");
    }
}
