class Listening : Activity
{
    public Listening():base
    ("Listening Activity",
    "This activity helps you reflect on the good things in your life by listing as many items as you can."){}

    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "Who are your heroes?",
        "What are you grateful for today?"
    };

    public void WhatItDo()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("List responses to the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.Write("You may begin in: ");
        Countdown(4);

        Thread.Sleep(3000);

        Console.WriteLine();

        List<string> answers = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < end)
        {
            Console.Write("> ");

            answers.Add(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {answers.Count} items!");

        DisplayEndingMessage();
    }
}