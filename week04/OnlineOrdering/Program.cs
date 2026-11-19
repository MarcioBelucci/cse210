using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("742 Evergreen Terrace", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Wireless Mouse", "WM-101", 25.00, 2);
        Product product2 = new Product("Mechanical Keyboard", "MK-204", 75.00, 1);
        Product product3 = new Product("USB-C Hub", "UH-309", 30.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        DisplayOrderDetails(order1, 1);

        Console.WriteLine();

        Address address2 = new Address("Av. Independência, 1200", "Piracicaba", "SP", "Brazil");
        Customer customer2 = new Customer("Ana Silva", address2);

        Product product4 = new Product("Webcam HD", "WC-410", 45.50, 2);
        Product product5 = new Product("Desk Lamp", "DL-512", 32.00, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        DisplayOrderDetails(order2, 2);
    }

    static void DisplayOrderDetails(Order order, int orderNumber)
    {
        Console.WriteLine($"==================== ORDER #{orderNumber} ====================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
        Console.WriteLine("==================================================");
    }
}