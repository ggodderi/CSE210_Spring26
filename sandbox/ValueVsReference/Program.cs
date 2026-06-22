class Program
{

    public static void PassArrayByValue(int[] data)
    {
        data[1] = 1001;
        Console.WriteLine($"In PassArrayByValue, data[1] is: {data[1]}");
    }

    public static void PassByOut(out int z)
    {
        z = 777;
        Console.WriteLine($"In PassByReference, z is: {z}");
    }

    public static void PassByReference(ref int x)
    {
        x++;
        Console.WriteLine($"In PassByReference, x is: {x}");
    }
    public static void PassByValue(int x)
    {
        x++;
        Console.WriteLine($"In PassByValue, x is: {x}");
    }

    public static void Main(string[] args)
    {
        int x = 10;
        int y = x;

        x++;
        Console.WriteLine(y);
        y++;

        Console.WriteLine(x);
        Console.WriteLine(y);

        string myName = "Bob";
        string myName2 = myName;

        myName += "Billy";

        Console.WriteLine(myName);
        Console.WriteLine(myName2);

        int[] myData = { 1, 2, 3, 4, 5, 6};

        int[] myData2 = myData;

        myData[3] = 99;

        Console.WriteLine(myData2[3]);
        
        x = 100;
        Console.WriteLine($"In Main Function before call, x is: {x}");
        PassByValue(x);
        Console.WriteLine($"In Main Function after call, x is: {x}");
        
        Console.WriteLine($"In Main before call, data[1] is: {myData[1]}");
        PassArrayByValue(myData);
        Console.WriteLine($"In Main after call, data[1] is: {myData[1]}");


        int z;
        Console.WriteLine($"In Main Function before PassByOut call, z is: {"UNDEFINED"}");
        PassByOut(out z);
        Console.WriteLine($"In Main Function after PassByOut call, z is: {z}");

    }
}

