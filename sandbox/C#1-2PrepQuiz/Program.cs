class Program
{
    public static void Main(string[] args)
    {
        // Collect input
        Console.Write("Enter your height in inches: ");

        int height = int.Parse(Console.ReadLine());

        Console.WriteLine($"You are {height} inches tall.");
        if (height < 48)
        {
            Console.WriteLine("Unfortunately you are too short to ride the ride.  Sorry.");
        }
        else if (height > 78)
        {
            Console.WriteLine("Unfortunately you are too tall to ride the ride.  Sorry.");   
        }
        else
        {
            Console.WriteLine("You may ride the ride.  Have a fun time.");
        }

    }
}