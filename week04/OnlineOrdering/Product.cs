public class Product
{
    private string _productName;
    private int _productId;
    private double _PricePerUnit;
    private int _quantityInOrder;
    public Product(string productName, int productId, double unitPrice, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _PricePerUnit = unitPrice;
        _quantityInOrder = quantity;
    }
    public double GetProductTotal()
    {
        return _PricePerUnit * _quantityInOrder;
    }
    public string GetProductInfo()
    {
        return $"{_productName} (ID: {_productId})";
    }
}
