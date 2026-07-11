class Product
{
    private string _name;
    private string _productID;
    private double _unitPrice;
    private int _quantity;
    public Product(string name, string productID, double unitPrice, int quantity)
    {
        _name=name;
        _productID=productID;
        _unitPrice=unitPrice;
        _quantity=quantity;
    }
    public double GetUnitPrice()
    {
        return _unitPrice;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
}