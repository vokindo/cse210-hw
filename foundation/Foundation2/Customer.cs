public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to initialize customer details
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer is in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to return the customer's shipping label
    public string GetShippingLabel()
    {
        return $"Customer: {_name}\n{_address.GetFullAddress()}";
    }
}
