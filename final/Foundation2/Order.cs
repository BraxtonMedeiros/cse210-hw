class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void SetProducts(List<Product> products)
    {
        _products = products;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculatePrice();
        }
        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} ({product.GetId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        return shippingLabel;
    }
}