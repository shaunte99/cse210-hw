public class Product
{
    private string _productName;
    private int _productId;
    private double _unitPrice;
    private int _quantity;
    public Product(string productName, int productId, double unitPrice, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }
    public double GetProductTotal()
    {
        return _unitPrice * _quantity;
    }
    public string GetProductInfo()
    {
        return $"{_productName} (ID: {_productId})";
    }
}
