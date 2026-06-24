class Product
{
    private string _name;
    private string _sku;
    
    public Product(string name, string sku)
    {
        _name = name;
        _sku = sku;
    }

    public string ProductGetInfo()
    {
        return $"{_name} ({_sku})";
    }
}