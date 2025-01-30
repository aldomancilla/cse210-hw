using System;

class Program
{
    static void Main(string[] args)
    {
        IJournalStorage storage = new FileJournalStorage();  
        Journal journal = new Journal(storage);

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                WriteEntry(journal);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                LoadJournal(journal);
            }
            else if (choice == "4")
            {
                SaveJournal(journal);
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("See you soon, Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }

    
    static void WriteEntry(Journal journal)
    {
        string prompt = Journal.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        journal.AddEntry(prompt, response);
        Console.WriteLine("Entry saved. Press any key to return to the menu...");
        Console.ReadKey();
    }

    
    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromStorage(filename);
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    
    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToStorage(filename);
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }
}
