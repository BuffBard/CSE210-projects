class Order
{
    private double _totalPrice=0;
    private List<Product>_products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products=products;
        _customer=customer;
    }
    public void FindTotalPrice()
    {
        foreach(Product product in _products)
        {
            _totalPrice+=product.GetUnitPrice()*product.GetQuantity();
            System.Console.WriteLine(_totalPrice);
        }
        if (_customer.InUSA())
            {
                _totalPrice+=5.00;
            }
            else{_totalPrice+=35.00;}
    }
    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach(Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} - {product.GetProductID()}");
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine("Shipping Label:");       //What is this spagetti code I have made..?
        Console.WriteLine($"{_customer.GetName()}\n{_customer.GetFullAddress().GetFullAddress()}");
    }
    public double GetTotalPrice()
    {
        return _totalPrice;
    }
}