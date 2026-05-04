using System;
using System.Linq.Expressions;

class Program
{

    static void DisplayGreeting()
    {
        Console.WriteLine("Hello Betty");
    }

    static double AddNumbers(int n1, int n2, double n3)
    {
        double total = n1 + n2 + n3;
        return total;
    }

    static void Main(string[] args)
    {
        DisplayGreeting();
        double total = AddNumbers(10, 20, 1001.234);
        Console.WriteLine(total);

        int x = 10;


        // Console.WriteLine("Hello");
        // int x = 10;
        // if (x == 11) 
        // {
        //     Console.WriteLine("Hey bob");
        //     Console.WriteLine("Hey Betty");
        // }

        // for (int i = 100000; i >= -200000; i -= 10000)
        // {
        //     Console.WriteLine(i);
        // }

        // int age = -1;

        // while (age < 0 || age > 125)
        // {
        //     Console.WriteLine("Please enter your age: ");
        //     age = int.Parse(Console.ReadLine());
        // }

        // int age2;

        // do
        // {
        //     Console.WriteLine("Please enter your age: ");
        //     age2 = int.Parse(Console.ReadLine()); 
        // }  while (age2 < 0 || age2 > 125);

        // string myString = "The quick brown fox jumps over the lazy dog.";
        // char myLetter = 'A';


        // for(int i = 0; i <= 32; ++i)
        // {
        //     uint powerNumber = (uint)Math.Pow(2, i);
        //     Console.Write($"2 to the power of {i}, is: {powerNumber}");
        //     Console.WriteLine($", 0x{powerNumber.ToString("X")}");
        // }


        // List<int> myData = new List<int>();
        // myData.Add(1);
        // myData.Add(2);
        // myData.Add(3);
        // myData.Add(4);
        // myData.Add(5);
        // myData.Add(99);
        // myData.Add(-100);
        // // myData.Add("Bob");
        // // myData.Add(123.234);
        // foreach(int i in myData)
        // {
        //     Console.WriteLine(i);   
        // }

        // Math.Pow() example

        // Random Examples 

        //List Example and foreach as well.


        // Function Example
    }
}

        // // Random Example
        // Random myRandomGenerator = new Random();
        // int randomNumber = myRandomGenerator.Next(1, 1000);
        // Console.WriteLine(randomNumber);

        // // List Example
        //     // Foreach example 
        // List<int> myData = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        // myData.Add(112);
        // myData.Add(0);
        // foreach(int i in myData)
        // {
        //     Console.WriteLine(i);
        // }

        // for(int i = 0; i <= 32; i++)
        // {
        //     Console.Write(i);
        //     uint powerValue = (uint)Math.Pow(2, i);
        //     Console.Write($", {powerValue}");
        //     Console.WriteLine($", {powerValue.ToString("X")}");
        // }

//         // This is a super duper cool comment.
//         // another comment
//         Console.WriteLine("Hello Sandbox World!");
//         int x = 10;
//         int y = x++;
//         Console.WriteLine($"{x} {y}");

//         double z = Math.Pow(2, 8);
//         Console.WriteLine(z);
        
//         for(int i = 0; i < 32; i++)
//         {
//             uint value = (uint)Math.Pow(2, i);
//             Console.Write(value);
//             Console.WriteLine($", 0x{value.ToString("X")}");
//         }

//         bool done = false;
//         int age = -1;

//         while (age < 0 || age > 125)
//         {
//             Console.WriteLine("Please input your age (0-125): ");
//             age = int.Parse(Console.ReadLine());
//         }

//         done = false;
//         int age2;
//         do
//         {
//             Console.WriteLine("Please input your age (0-125): ");
//             age2 = int.Parse(Console.ReadLine());
//         } while (age2 < 0 || age2 > 125);

//         List<string> myFriends = new List<string>{"betty", "bob", "bubby"};
//         myFriends.Add("Jeannie");
//         foreach(string s in myFriends)
//         {
//             Console.WriteLine(s);
//         }

//         Random myRandomGenerator = new Random();
//         int randomNumber  = myRandomGenerator.Next(1, 1000);
//         Console.WriteLine("" + randomNumber);
//     }
// }