class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("This is a test");
        // Thread.Sleep(2000);
        // Console.WriteLine("This is a test 2");



        Console.CursorVisible = false;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("+");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            // Console.Write('\b');
        }

        string animationString = "-\\|/";
        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            // Console.Write('\b');
        }

        DateTime now = DateTime.Now;
        DateTime stopTime = now.AddSeconds(15);
        string animationStringFace = "(^_^)(-_-)";
        while(DateTime.Now < stopTime)
        {
            Console.Write(animationStringFace[0..5]);
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationStringFace[5..]);
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
            // Console.Write('\b');
        }


        Console.CursorVisible = true;

    }
}
