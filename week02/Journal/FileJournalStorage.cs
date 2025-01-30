using System;
using System.Collections.Generic;
using System.IO;

public class FileJournalStorage : IJournalStorage
{
    
    public void Save(List<JournalEntryBase> entries, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToStorageFormat());
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

   
    public List<JournalEntryBase> Load(string fileName)
    {
        var entries = new List<JournalEntryBase>();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        var entry = new JournalEntry(parts[1], parts[2])
                        {
                            Date = parts[0]
                        };
                        entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }

        return entries;
    }
}