class PhysicalProduct : Product
{
    private double _weight;
    public PhysicalProduct(string name, string sku, double weight): base(name, sku)
    {
        _weight = weight;
    }

    public override string GetInfo()
    {
        return $"Physical Item: {base.GetInfo()} - Weight: {_weight}kg";
    }
}