using System;

public class Product{
    private string Name {get; set;}
    private int ProductId {get; set;}
    private decimal Price {get; set;}
    private int Quantity {get; set;}

    // This constructor initializes the product 
    public Product(string name, int productId, decimal price, int quantity){
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    // This method calculates the total cost of the product 
    public decimal GetTotalCost(){
        return Price * Quantity;
    }

    // This method gets the products name 
    public string GetName(){
        return Name;
    }

    // This method gets the ID for the product
    public int GetProductId(){
        return ProductId;
    }
}