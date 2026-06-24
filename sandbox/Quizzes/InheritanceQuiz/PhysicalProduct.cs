class PhysicalProduct : Product
{
    private double _weight;
    public PhysicalProduct(string name, string sku, double weight): base(name, sku)
    {
        _weight = weight;
    }

    public string GetInfo()
    {
        return $"Physical Item: {ProductGetInfo()} - Weight: {_weight}kg";
    }
}