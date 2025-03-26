public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            //update the current word to be hidden
            _words[index].Hide();
            //update the current word text with hidden charcater with _underscore or not
            _words[index].SetText(_words[index].GetDisplayText());
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string text = string.Join(' ', _words.Select(w => w.GetDisplayText()));
        string reference = _reference.GetDisplayText();
        return $"{reference} {text}";
    }

}