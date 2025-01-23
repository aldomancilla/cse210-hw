using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("This line is an example in C#.");

        Console.WriteLine("What is your first name? ");
        string first = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is: {last}, {first} {last}.");
    }
}