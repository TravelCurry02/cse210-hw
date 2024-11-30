using System;

class Program{
    static void Main(){
        // Create an address and customer for the first order
        Address address_01 = new Address("5814 Main St.", "Colorado", "CO", "USA");
        Customer customer_01 = new Customer("Josh Hendrix", address_01);
        Order order_01 = new Order(customer_01);

        // Add products to order 
        Product product_01 = new Product("Laptop", 101, 749.99m, 1);
        Product product_02 = new Product("Mouse", 102, 15.99m, 2);
        order_01.AddProduct(product_01);
        order_01.AddProduct(product_02);

        // Display the packing lable, the shipping lable, and the total cost for the first order
        Console.WriteLine(order_01.GetPackingLable());
        Console.WriteLine(order_01.GetShippingLable());
        Console.WriteLine($"Total Cost: {order_01.GetTotalCost():C}\n");

        // repeat this for all the other customers and their orders 

        Address address_02 = new Address("3574 Nevermore Dr", "Ontario", "ON", "Canada");
        Customer customer_02 = new Customer("Jonny Smithfield", address_02);
        Order order_02 = new Order(customer_02);

        Product product_03 = new Product("iPhone", 103, 150m, 1);
        Product product_04 = new Product("Earbuds", 104, 49.99m, 1);
        order_02.AddProduct(product_03);
        order_02.AddProduct(product_04);

        Console.WriteLine(order_02.GetPackingLable());
        Console.WriteLine(order_02.GetShippingLable());
        Console.WriteLine($"Total Cost: {order_02.GetTotalCost():c}");
    }
}