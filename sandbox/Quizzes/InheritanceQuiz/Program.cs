class Program
{
    public static void Main(string[] args)
    {
        PhysicalProduct p1 = new PhysicalProduct("Toaster", "T-100", 4.5);
        DigitalProduct d1 = new DigitalProduct("E-Book", "EB-99", "http://d1.com/book");

        Console.WriteLine(p1.GetInfo());
        Console.WriteLine(d1.GetInfo());

    }
}