
class Customer
{
    private string _name;
    private int _id;
    private bool _isMember;

    public Customer(string name, int id) : this(name, id, false)
    {
        // _name = name;
        // _id = id;
        // _isMember = false;
        // this(name, id, false);
    }

    
    public Customer(string name, int id, bool isMember)
    {
        _name = name;
        _id = id;
        _isMember = isMember;
    }
    public string GetInfo()
    {
        return $"Customer: {_name} ({_id}) - Member {_isMember}";
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Customer C1 = new Customer("Bob", 569, true);
        Customer C2 = new Customer("Jose", 473);

        Console.WriteLine(C1.GetInfo());
        Console.WriteLine(C2.GetInfo());

    }
}