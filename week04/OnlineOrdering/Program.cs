using System;

class Program
{
    static void Main(string[] args)
    {

        // Address >> Customer >> Product >> Order


        //Customer 1
        Address customerAddress1 = new Address("123 Maple Street", "Springfield", "IL", "62704", "USA");
        Customer customerInfo1 = new Customer("Bruno", customerAddress1);

        // Products
        Product product1 = new Product("iPhone 14 Pro", "A005", 999.1, 2);
        Product product2 = new Product("1TB Hard Drive", "PC09", 59.99, 3);
        Product product3 = new Product("Dell Laptop", "L032", 1119, 1);

        // Order
        Order customerOrder1 = new Order(customerInfo1);
        customerOrder1.AddProduct(product1);
        customerOrder1.AddProduct(product2);
        customerOrder1.AddProduct(product3);

        Console.WriteLine("---------------------------------------");
        Console.WriteLine(customerOrder1.PackingLabel());
        Console.WriteLine(customerOrder1.ShippingLabel());
        Console.WriteLine($"\t\tTotal: US${customerOrder1.TotalOrderCost():F2}");


        // Customer 2
        Address customerAddress2 = new Address("456 Oak Avenue", "Toronto", "ON", "M4B1B3", "Canada");
        Customer customerInfo2 = new Customer("Mariana", customerAddress2);

        // Products
        Product product4 = new Product("Samsung Galaxy S23", "A010", 850.75, 1);
        Product product5 = new Product("Wireless Mouse", "AC12", 25.50, 2);
        Product product6 = new Product("Mechanical Keyboard", "AC33", 120.00, 1);

        // Order
        Order customerOrder2 = new Order(customerInfo2);
        customerOrder2.AddProduct(product4);
        customerOrder2.AddProduct(product5);
        customerOrder2.AddProduct(product6);

        Console.WriteLine("---------------------------------------");
        Console.WriteLine(customerOrder2.PackingLabel());
        Console.WriteLine(customerOrder2.ShippingLabel());
        Console.WriteLine($"\t\tTotal: US${customerOrder2.TotalOrderCost():F2}");




    }
}