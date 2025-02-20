using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Exit");
            Console.Write("Select a choice from the menu: ");
            
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) manager.CreateGoal();
            else if (choice == 2) manager.ListGoals();
            else if (choice == 3) manager.SaveGoals();
            else if (choice == 4) manager.LoadGoals();
            else if (choice == 5) manager.RecordEvent();
            else if (choice == 6) manager.ShowScore();
            else if (choice == 7) break;
        }
    }
}