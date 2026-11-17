public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0; // 0 means there is no end verse

    public Reference(string book, int chapter, int verse)
    {
        
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        
    }
    
    public string GetDisplayText()
    {
        return "";
    }

}