// Journal.cs
using System;
using System.Collections.Generic;

public class Journal
{
    private IJournalStorage _storage; 
    public List<JournalEntryBase> Entries { get; private set; } 

    public Journal(IJournalStorage storage)
    {
        _storage = storage;  
        Entries = new List<JournalEntryBase>();
    }

   
    public void AddEntry(string prompt, string response)
    {
        var entry = new JournalEntry(prompt, response);
        Entries.Add(entry);
    }

   
    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    
    public void SaveToStorage(string fileName)
    {
        _storage.Save(Entries, fileName);
    }

   
    public void LoadFromStorage(string fileName)
    {
        Entries = _storage.Load(fileName);
    }

    
        public static string GetRandomPrompt()
    {
        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was your greatest achievement today?",
            "What was the funniest part of your day?",
            "Did you serve anyone today?"
        };

        var random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
}
