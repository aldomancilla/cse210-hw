using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1) Start breathing activity");
            Console.WriteLine("2) Start reflecting activity");
            Console.WriteLine("3) Start listing activity");
            Console.WriteLine("4) Quit");
            Console.Write("Please select a choice: ");

            switch (Console.ReadLine())
            {
                case "1": new BreathingActivity().Start(); break;
                case "2": new ReflectionActivity().Start(); break;
                case "3": new ListingActivity().Start(); break;
                case "4": return;
                default: Console.WriteLine("Invalid option. Try again."); break;
            }
        }
    }
}
