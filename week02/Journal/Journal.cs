public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        
    }

    public void SaveToFile(string filename)
    {
        
    }

    public void LoadFromFile(string filename)
    {
        
    }
}