public class JournalEntry : JournalEntryBase
{
    public JournalEntry(string prompt, string response) : base(prompt, response) { }

    public override string ToStorageFormat()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}
