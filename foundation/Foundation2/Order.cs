using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

public class Order{
    private List<Product> Products {get; set;}
    private Customer Customer {get; set;}

    // This constructior initializes the order 
    public Order(Customer customer){
        Products = new List<Product>();
        Customer = customer;
    }

    // This method adds a product to the order 
    public void AddProduct(Product product){
        Products.Add(product);
    }

    // This method calculates the total cost of the order including (products + shipping)
    public decimal GetTotalCost(){
        decimal total = 0;

        foreach (var product in Products){
            total += product.GetTotalCost();
        }

        decimal shippingCost = Customer.IsInUSA() ? 5 : 35;
        total += shippingCost;
        return total; 
    }

    // This method gets the packing label 
    public string GetPackingLable(){
        string packingLable = "packing Lable:\n";
        foreach (var product in Products){
            packingLable += $"Product: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLable;
    }

    // This method gets the shipping label 
    public string GetShippingLable(){
        return $"shipping Lable:\n{Customer.GetName()}\n{Customer.GetAddress().GetFullAddress()}";
    }
}