using System;

public class Customer{
    private string Name {get; set;}
    private Address CustomerAddress {get; set;}

    // This constructior initializes the customer 
    public Customer(string name, Address address){
        Name = name;
        CustomerAddress = address;
    }

    // This method checks if the customer is in the USA
    public bool IsInUSA(){
        return CustomerAddress.IsInUSA();
    }

    // This method gets the customer's name 
    public string GetName(){
        return Name; 
    }

    // This method gets the customer's address
    public Address GetAddress(){
        return CustomerAddress;
    }
}