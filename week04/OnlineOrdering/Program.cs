public class Program
{
    public static void Main(string[] args)
    {
        // Create Address instances for U.S. customers
        Address address1 = new Address("123 Soul Street", "Atlanta", "Georgia", "United States");
        Address address2 = new Address("456 Legacy Blvd", "Chicago", "Illinois", "United States");

        // Create Customer instances with names inspired by Black American culture
        Customer customer1 = new Customer("Tyrone Johnson", address1);
        Customer customer2 = new Customer("Darius Brown", address2);

        // Create Product instances
        Product product1 = new Product("Fresh Kicks", 301, 120.99, 1);
        Product product2 = new Product("Gold Chain", 302, 250.50, 2);
        Product product3 = new Product("Bluetooth Speaker", 303, 59.99, 3);
        Product product4 = new Product("Jacket", 304, 80.00, 1);

        // Create Order instances and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display Packing Labels, Shipping Labels, and Total Cost
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost for Order 1: ${order1.CalculateOrderTotal():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost for Order 2: ${order2.CalculateOrderTotal():F2}");
    }
}
