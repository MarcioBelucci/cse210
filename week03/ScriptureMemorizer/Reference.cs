using System.Runtime.CompilerServices;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0; // 0 means there is no end verse

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if(_endVerse == 0)
        {
            return new string($"{_book} {_chapter}:{_verse}");
        }
        else 
        {
            return new string($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
    }

}