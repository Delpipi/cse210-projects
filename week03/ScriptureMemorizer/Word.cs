public class Word
{

    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Need Setter to update the word in scripture hidden text operation 
    public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? HideWord() : _text;
    }

    private string HideWord()
    {
        /* StringBuilder hiderWord = new StringBuilder();
        foreach (char character in _text)
        {
            hiderWord.Append("_");
        }
        return hiderWord.ToString(); */
        return string.Concat(_text.Select(c => '_'));
    }
}