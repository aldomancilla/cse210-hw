public interface IJournalStorage
{
    void Save(List<JournalEntryBase> entries, string fileName);  
    List<JournalEntryBase> Load(string fileName);
}
