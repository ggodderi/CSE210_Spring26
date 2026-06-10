using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {

        int sleepTime = 250;

        Console.Clear();
        Console.CursorVisible = false;
        // for (int i = 0; i < 20; i++)
        // {
        //     Console.Write("+");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");

        // }

        // string animationString = "-\\|/";
        // DateTime now = DateTime.Now;
        // DateTime endTime = now.AddSeconds(10);
        // // int index = 0;
        // // for (int i = 0; i < 20; i++)
        // // Console.WriteLine("" + now.ToString(""));
        // int index = 0;
        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }
        // Console.WriteLine("" + now.ToString(""));

        int count = 15;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(count);
        // int index = 0;
        // for (int i = 0; i < 20; i++)
        // Console.WriteLine("" + now.ToString(""));
        // while(DateTime.Now < endTime)
        // while(count >= 0)
        // {
        //     Console.Write($"{count--,2}");
        //     Thread.Sleep(1000);
        //     Console.Write("\b\b");
        // }
        // Console.WriteLine("" + now.ToString(""));


        // Animate faces.
        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");

        }

        Console.CursorVisible = true;

    }
}




    //     int sleepTime = 250;

    //     Console.Clear();
    //     Console.CursorVisible = false;
    //     // for (int i = 0; i < 20; i++)
    //     // {
    //     //     Console.Write("+");
    //     //     Thread.Sleep(sleepTime);
    //     //     Console.Write("\b");
    //     //     Console.Write("-");
    //     //     Thread.Sleep(sleepTime);
    //     //     Console.Write("\b");

    //     // }

    //     DateTime now = DateTime.Now;
    //     DateTime endTime = now.AddSeconds(20);


    //     string animationString = "-\\|/";
    //     // int index = 0;
    //     for (int i = 0; i < 20; i++)
    //     {
    //         Console.Write(animationString[i % animationString.Length]);
    //         Thread.Sleep(sleepTime);
    //         Console.Write("\b");
    //     }

    //     int index = 0;
    //     while(DateTime.Now < endTime)
    //     {
    //         Console.Write(animationString[index++ % animationString.Length]);
    //         Thread.Sleep(sleepTime);
    //         Console.Write("\b");            
    //     }

    //     int countDownTime = 15;
    //     while(countDownTime > 0)
    //     {
    //         Console.Write($"{countDownTime--, 2}");
    //         Thread.Sleep(1000);
    //         Console.Write("\b\b");
    //     }

    //     Console.CursorVisible = true;

    // }