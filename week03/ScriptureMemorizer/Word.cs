public class Word(string word)
{
    private string _word = word;
    private bool _isHidden = false;

    // Hide a word
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {   
            string hidden = "";
            foreach (char c in _word)
            {
                hidden += "_";
            }
            return hidden;
        } else
        {
            return _word;
        }
    }
}