using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Going to sleep for a second...");
        
        Console.Write("+");
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(10000);
     

        Console.WriteLine("I'm back!!");

    }
}