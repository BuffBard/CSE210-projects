class Activity
{
    protected int _time;
    protected string _description;
    protected string _name;
    protected string _prompt;


public Activity(string name, string description)
    {
        _name=name;
        _description=description;
    }
public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like your session? ");
        _time = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Get ready...");
        Countdown(3);
    }

public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Thread.Sleep(2000);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_time} seconds of the {_name}.");
        Thread.Sleep(2000);
    }
public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}