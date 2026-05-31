class WordState
{
    private bool _hidden;
    private string _word;
    public WordState(string word)
    {
        _word=word;
        _hidden=false;
    }

    public void Hide()
    {
        _hidden=true;
    }
    public string DisplayWord()
    {
        if (_hidden)
        {
            return new string('_', _word.Length);
        }
      return _word;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
}