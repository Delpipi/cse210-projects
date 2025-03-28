using System;

class Program
{
    static void Main(string[] args)
    {
        //Create 3 Addresses
        Address address1 = new Address("456 Oak Street", "Los Angeles", "California", "USA");
        Address address2 = new Address("123 Desert Drive", "Salt Lake City", "Utah", "USA");
        Address address3 = new Address("101 Maple Avenue", "Toronto", "Ontario ", "Canada");
        Address address4 = new Address("789 Harbour Road", "Sydney", "New South Wales ", "Australia");

        //Create 4 Customers 
        Customer customer1 = new Customer("Sarah Johnson", address1);
        Customer customer2 = new Customer("Michael Lee", address2);
        Customer customer3 = new Customer("Emma Williams", address3);
        Customer customer4 = new Customer("James Smith", address4);

        //Create 5 products
        Product product1 = new Product("Wireless Mouse", 106, 29.99, 10);
        Product product2 = new Product("4K Television", 107, 499.99, 3);
        Product product3 = new Product("Bluetooth Speaker", 108, 79.99, 8);
        Product product4 = new Product("External Hard Drive", 109, 89.99, 6);
        Product product5 = new Product("Electric Kettle", 110, 34.99, 15);

        //Create 3 orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);



        Order order2 = new Order(customer4);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order(customer3);
        order3.AddProduct(product5);

        //List of orders
        Console.WriteLine("\n========== ORDER 1 ==============");
        Console.WriteLine($"Packing Label : {order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label : {order1.GetShippingLabel()}");
        Console.WriteLine($"Total Price : ${order1.GetTotalPrice()}");

        Console.WriteLine("\n========== ORDER 2 ==============");
        Console.WriteLine($"Packing Label : {order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label : {order2.GetShippingLabel()}");
        Console.WriteLine($"Total Price : ${order2.GetTotalPrice()}");

        Console.WriteLine("\n========== ORDER 3 ==============");
        Console.WriteLine($"Packing Label : {order3.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label : {order3.GetShippingLabel()}");
        Console.WriteLine($"Total Price : ${order3.GetTotalPrice()}");

    }
}