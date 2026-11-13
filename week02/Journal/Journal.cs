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
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToFileLine());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        List<Entry> loaded = new List<Entry>();
        
        foreach (string line in File.ReadAllLines(filename))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            loaded.Add(Entry.FromFileLine(line));
        }
        
        _entries = loaded;
        
    }
}