public class Product
{
    private string _name;
    private string _productId;
    private decimal _pricePerUnit;
    private int _quantity;

    // Constructor to initialize product details
    public Product(string name, string productId, decimal pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Method to calculate total cost for the product
    public decimal GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    // Method to return product details for the packing label
    public string GetPackingLabel()
    {
        return $"Product: {_name}, ID: {_productId}";
    }
}
