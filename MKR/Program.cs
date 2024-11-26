using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {userName}!");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
