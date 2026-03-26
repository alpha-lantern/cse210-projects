using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("bread", "1011", 5.25, 2);
        Product product2 = new Product("candy", "1201", 0.20, 10);
        Product product3 = new Product("honey", "0071", 15.85, 1);
        Product product4 = new Product("ham", "2005", 7.99, 1);
        Product product5 = new Product("butter", "1009", 9.99, 3);
        Product product6 = new Product("jam", "1024", 8.49, 2);
        Product product7 = new Product("beef", "2024", 28.89, 1);

        Customer matt = new Customer("Matt");
        matt.SetAddress("Av. Brasil 2102", "Lima", "Lima", "Peru");
        
        Customer dew = new Customer("Dew");
        dew.SetAddress("First Street 152", "Nephi", "Utah", "USA");
        
        Customer red = new Customer("Red");
        red.SetAddress("Green St 987", "Alvin", "Texas", "USA");

        Order mattOrder = new Order(matt);
        mattOrder.AddProduct(product1);
        mattOrder.AddProduct(product3);
        mattOrder.AddProduct(product6);

        Order dewOrder = new Order(dew);
        dewOrder.AddProduct(product2);
        dewOrder.AddProduct(product3);
        dewOrder.AddProduct(product7);

        Order redOrder = new Order(red);
        redOrder.AddProduct(product4);
        redOrder.AddProduct(product5);
        redOrder.AddProduct(product1);

        // Display results to the console
        // Matt
        List<string> packagingLabel = mattOrder.GetPackagingLabel();
        Console.WriteLine("Packaging Label:");
        foreach (string label in packagingLabel)
        {
            Console.WriteLine(label);
        }
        
        string shippingLabel = mattOrder.GetShippingLabel();
        Console.WriteLine($"Shipping Label: {shippingLabel}");

        double totalCost = mattOrder.GetTotalCost();
        Console.WriteLine($"Total Cost: ${totalCost}");
        Console.WriteLine(); // Blank line

        // Dew
        packagingLabel = dewOrder.GetPackagingLabel();
        Console.WriteLine("Packaging Label:");
        foreach (string label in packagingLabel)
        {
            Console.WriteLine(label);
        }
        
        shippingLabel = dewOrder.GetShippingLabel();
        Console.WriteLine($"Shipping Label: {shippingLabel}");

        totalCost = dewOrder.GetTotalCost();
        Console.WriteLine($"Total Cost: ${totalCost}");
        Console.WriteLine(); // Blank line

        // Red
        packagingLabel = redOrder.GetPackagingLabel();
        Console.WriteLine("Packaging Label:");
        foreach (string label in packagingLabel)
        {
            Console.WriteLine(label);
        }
        
        shippingLabel = redOrder.GetShippingLabel();
        Console.WriteLine($"Shipping Label: {shippingLabel}");

        totalCost = redOrder.GetTotalCost();
        Console.WriteLine($"Total Cost: ${totalCost}");
        Console.WriteLine(); // Blank line
    }
}