using System;

public abstract class JournalEntryBase
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntryBase(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public abstract string ToStorageFormat();

    public override string ToString()
    {
        return $"{Date} - Prompt: {Prompt}\nResponse: {Response}\n";
    }
}
