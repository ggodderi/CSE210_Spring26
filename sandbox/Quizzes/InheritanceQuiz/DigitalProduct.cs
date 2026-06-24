class DigitalProduct : Product
{
    private string _downloadURL;
    public DigitalProduct(string name, string sku, string downloadURL): base(name, sku)
    {
        _downloadURL = downloadURL;
    }

    public string GetInfo()
    {
        return $"Digital Item: {ProductGetInfo()} - Link: {_downloadURL}";
    }
}