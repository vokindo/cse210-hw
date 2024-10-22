using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order with products and a customer
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Method to calculate total cost including shipping
    public decimal GetTotalCost()
    {
        decimal totalProductCost = 0;

        // Sum up the total cost of all products
        foreach (var product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        // Determine the shipping cost
        decimal shippingCost = _customer.IsInUSA() ? 5 : 35;

        // Return the total cost including shipping
        return totalProductCost + shippingCost;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetShippingLabel()}";
    }
}
