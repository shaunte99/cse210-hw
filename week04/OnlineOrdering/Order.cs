using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> _productList;
    private Customer _orderCustomer;
    public Order(Customer customer)
    {
        _orderCustomer = customer;
        _productList = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }
      public double CalculateOrderTotal()
    {
        double totalAmount = 0;
        foreach (Product product in _productList)
        {
            totalAmount += product.GetProductTotal();
        }

        totalAmount += _orderCustomer.GetCustomerAddress().IsInUS() ? 5 : 35;
       
        return totalAmount;
    }
      public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _productList)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label;
    }
      public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += _orderCustomer.GetCustomerInfo();
        return label;
    }
}
