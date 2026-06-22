class Reflection : Activity
{
    public Reflection():base(
            "Reflection Activity",
            "This activity helps you reflect on moments when you showed strength and resilience."){}

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "Have you done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "What made this experience special?",
        "What can you apply to your future?",
        "How can you remember this experience?"
    };

    public void WhatItDo()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each question:");

        DateTime end = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < end)
        {
            Console.WriteLine();

            Console.WriteLine("> " + _questions[random.Next(_questions.Count)]);

            Spinner(6);
        }

        DisplayEndingMessage();
    }
}