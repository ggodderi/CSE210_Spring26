class Program
{

    static double  FindSmallest(List<double> data)
    {
        double smallest = data[0];
        foreach (double d in data)
        {
            if (d < smallest)
            {
                smallest = d;
            }
        }
        return smallest;
    }
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hey");
        List<double> data = new List<double> {9.58, 9.69, 9.72, 9.74, 9.78 };

        Console.WriteLine(FindSmallest(data));
    }
}