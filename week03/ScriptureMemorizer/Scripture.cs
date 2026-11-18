using System.Runtime.InteropServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string result = $"{_reference.GetDisplayText()} ";

        foreach (Word word in _words)
        {
            result = result + word.GetDisplayText() + " ";
        }

        return result;
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}