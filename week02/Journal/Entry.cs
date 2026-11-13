public class Entry
{
    private string _date = "";
    private string _promptText = "";
    private string _entryText = "";

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public string ToFileLine()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileLine(string line)
    {
        string[] parts = line.Split('|', 3);
        if (parts.Length < 3)
        {
            throw new FormatException("Invalid file line format.");
        }

        return new Entry(parts[0], parts[1], parts[2]);
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }
}