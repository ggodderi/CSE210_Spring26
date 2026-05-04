using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name: ");
        string firstName;
        firstName = Console.ReadLine();

        Console.Write("What is your first name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"{lastName}, {firstName} {lastName}");

        int x = 10;

        if( x == 10)
        {
            Console.WriteLine("10");
        }
        else if ( x == 20)
        {
            Console.WriteLine("bwetyer");
        }
        else
        {
            
        }

    }
}