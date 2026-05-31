class VerseReference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public VerseReference(string book, int chapter, int startVerse)
    {
        _book=book;
        _chapter=chapter;
        _startVerse=startVerse;
        _endVerse=0;
    }
    public VerseReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book=book;
        _chapter=chapter;
        _startVerse=startVerse;
        _endVerse=endVerse;
    }
    public string GetReference()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }

        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
    }