using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        ParseText(text);
    }

    // METHODS
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}";
        foreach (Word word in _words)
        {
            displayText += $" {word.GetDisplayText()}";
        }
        return displayText;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        int hiddenThisTime = 0;
        int wordSelector;
        while (hiddenThisTime != numberToHide)
        {
            wordSelector = randomGenerator.Next(0, _words.Count);
            // Hide words
            if (!_words[wordSelector].IsHidden())
            {
                _words[wordSelector].Hide();
                hiddenThisTime++;
            }
            // Check if is there's no more words to hide, before continue hiding words
            if (IsCompletelyHidden())
            {
                break;
            }
        }
        Console.WriteLine(GetDisplayText());
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    private void ParseText(string text)
    {
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word newWord = new Word(word.Trim());
            _words.Add(newWord);
        }
    }

    // Experimental function
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        
        int refIndex = 0;
        int textIndex = 1;

        string referenceText = lines[refIndex];

        _reference = _reference.LoadReference(referenceText);
        _words = [];

        for (int i = textIndex; i < lines.Length; i++)
        {
            ParseText(lines[i]);
        }
    }
}