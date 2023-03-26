using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a product
        Product product1 = new Product("Laptop", "1001", 900, 1);

        // Create another product
        Product product2 = new Product("Mouse", "1002", 25, 2);

        // Create a customer
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create an order
        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        Order order1 = new Order(customer1, products1);

        // Create another customer
        Address address2 = new Address("456 Park Ave", "Othertown", "TX", "USA");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create another order
        Product product3 = new Product("Keyboard", "1003", 50, 1);
        List<Product> products2 = new List<Product>();
        products2.Add(product2);
        products2.Add(product3);
        Order order2 = new Order(customer2, products2);

        // Display the packing label and shipping label for each order
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        // Display the total cost of each order
        Console.WriteLine("Order 1 Total Cost: $" + order1.CalculateTotalCost().ToString());
        Console.WriteLine("Order 2 Total Cost: $" + order2.CalculateTotalCost().ToString());
    }
}