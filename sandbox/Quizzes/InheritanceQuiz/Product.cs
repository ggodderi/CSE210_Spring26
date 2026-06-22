class Product
{
    private string _name;
    private string _sku;
    
    public Product(string name, string sku)
    {
        _name = name;
        _sku = sku;
    }

    public virtual string GetInfo()
    {
        return $"{_name} ({_sku})";
    }
}