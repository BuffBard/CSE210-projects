using System.Data;

class Scripture
{
    private VerseReference _reference;
    private List<WordState> _words;
    private Random _random=new Random();
    private List<WordState> visibleWords = new List<WordState>();

    public Scripture(VerseReference reference, string text)
    {
        _reference=reference;
        _words=new List<WordState>();

        string[] splitWords=text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string word in splitWords)
        {
            _words.Add(new WordState(word));
        }
    }
    public string GetDisplayText()
    {
        List<string> displayWords=new List<string>();
        foreach(WordState word in _words)
        {
            displayWords.Add(word.DisplayWord());
        }
        return _reference.GetReference()+ " "+string.Join(" ", displayWords);
    }
    public void HideRandomWords(int count)
    {

    int visibleCount = 0;

    foreach (WordState word in _words)
        {
            if (!word.IsHidden())
            {
                visibleCount++;
            }
        }

        if (count > visibleCount)
            {
                count = visibleCount;
            }

        for (int i = 0; i < count; i++)
            {
                int index = _random.Next(_words.Count);

                if (_words[index].IsHidden())
                {
                    i--;
                    continue;
                }

                _words[index].Hide();
            }
    }
    public bool IsFullyHidden()
    {
        foreach (WordState word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}