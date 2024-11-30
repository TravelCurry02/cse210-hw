using System;
using System.Collections.Generic;

public class Order{
    private List<Product> Products {get; set;}
    private Customer Customer {get; set;}

    public Order(Customer customer){
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product){
        Products.Add(product);
    }

    public decimal GetTotalCost(){
        decimal total = 0;

        foreach (var product in Products){
            total += product.GetTotalCost();
        }

        decimal shippingCost = Customer.IsInUSA() ? 5 : 35;
        total += shippingCost;
        return total; 
    }

    public string GetPackingLable(){
        string packingLable = "packing Lable:\n";
        foreach (var product in Products){
            packingLable += $"Product: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLable;
    }

    public string GetShippingLable(){
        return $"shipping Lable:\n{Customer.GetName()}\n{Customer.GetAddress().GetFullAddress()}";
    }
}