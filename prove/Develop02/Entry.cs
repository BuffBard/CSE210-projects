

class Entry
{
    //Atributes
    public string _date;
    public string _prompt;
    public string _response;

    //Behaviors
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}\n{_response}");
    }
    public string GetPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Talk about that one guy named Greg.",
            "What was the best meal you have had recently?",
            "Why did you eat ketchup and banana?"
        };
        Random _rng=new Random();
        int _randint=_rng.Next(prompts.Count);
        return prompts[_randint];
    }
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        return $"{theCurrentTime.ToShortDateString()}";
    }
}