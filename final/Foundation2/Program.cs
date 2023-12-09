using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("324 Kast St ", "Berat ", "Fier ", 99999 , "ALB");
        Customer customer1 = new Customer("Klaus Ausman", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Computer Mouse", "CM021", 76.95, 1);
        Product p1002 = new Product("12GB Ram", "RA12G", 200.00, 3);
        Product p1003 = new Product("Long Mouse Pad", "LMP03", 35.00, 2);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("4382 W. Johnson ", "Hobby ", "TX ", 85001 , " USA");
        Customer customer2 = new Customer("Jim Jones", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("CPU Fan", "CPF", 45.00, 1);
        Product p2002 = new Product("Keyboard", "KEY100", 17.00, 1);
        Product p2003 = new Product("WIFI Adaptor Dongle", "WAD101", 15.00, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("1228 E Center Street ", "Pocatello ", "ID", 83201, "USA");
        Customer customer3 = new Customer("Belinda Gayes", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Standing Desk", "SD100", 100.99, 1);
        Product p3002 = new Product("Ream of Printer Paper", "ROPP", 10.00, 2);
        Product p3003 = new Product("Really Nice Markers", "RNM203", 50.00, 2);

        productsList3.Add(p3001);
        productsList3.Add(p3002);
        productsList3.Add(p3003);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    
    }
}