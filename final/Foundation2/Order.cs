using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private decimal _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
        _shippingCost = CalculateShippingCost();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.GetPrice() * product.GetQuantity();
        }
        return totalCost + _shippingCost;
    }
    public string GeneratePackingLabel()
    {
        string packingLabel= $"Packing Label\nCustomer: {_customer.GetName()}\n";
        foreach( Product product in _products)
        {
            packingLabel += $"Products: {product.GetName()}, ID: {product.GetId()}\n";
        }
        return packingLabel;
    }
    public string GenerateShippingLabel()
    {
        string shippingLabel = $"Shipping Label\nCustomer: {_customer.GetName()}\n";
        shippingLabel += $"Address: {_customer.GetAddress().GetFullAddress()}\n";
        return shippingLabel;
    }
    
    private decimal CalculateShippingCost()
    {
        if (_customer.IsInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}
