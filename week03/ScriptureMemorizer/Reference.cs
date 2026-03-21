public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string displayText = $"{_book} {_chapter}:{_verse}";
        if (_endVerse > 0)
        {
            displayText += $"-{_endVerse}";
        }
        return displayText;
    }

    public Reference LoadReference(string text)
    {
        // Split reference
        string[] reference = text.Split(" ");
        int bookIndex = 0;
        int chapterIndex = bookIndex + 1;

        string book = reference[bookIndex];
        // If the book has a suffix number
        if (reference.Length > 2) {
            book += reference[bookIndex + 1];
            chapterIndex ++;
        }
        string[] chapterVerses = reference[chapterIndex].Split(':', '-');
        // Now the chapter is the first item in the new array
        chapterIndex = 0;
        // Initial verse position
        int verseIndex = chapterIndex + 1;

        // Name the numbers in the array
        int chapter = int.Parse(chapterVerses[chapterIndex]);
        int verse = int.Parse(chapterVerses[verseIndex]);
        int endVerse = 0;
        // If there's more than one verse
        if (chapterVerses.Length > 2) {
            endVerse = int.Parse(chapterVerses[verseIndex + 1]);
        }

        Reference newRef = new Reference(book, chapter, verse, endVerse);
        return newRef;

        // _book = book;
        // _chapter = chapter;
        // _verse = verse;
        // _endVerse = endVerse;
    }
}