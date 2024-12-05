using System;

public class Address{

    private string StreetAddress {get; set;}
    private string City {get; set;}
    private string StateProvince {get; set;}
    private string Country {get; set;}

    // This constructor initializes the address
    public Address(string streetAddress, string city, string stateProvince, string country){
        StreetAddress = streetAddress;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    // This method checks to see if the address is in the USA
    public bool IsInUSA(){
        return Country.ToLower() == "usa";
    }

    // This method gets the address into one string
    public string GetFullAddress(){
        return $"{StreetAddress}\n{City}, {StateProvince}\n{Country}";
    }
}
