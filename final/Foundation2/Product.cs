class Product
{
    private string _name;
    private string _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetId()
    {
        return _id;
    }

    public void SetId(string id)
    {
        _id = id;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public decimal CalculatePrice()
    {
        return _price * _quantity;
    }
}