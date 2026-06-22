class Breathing : Activity
{
    public Breathing():base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."){}

    public void WhatItDo(){
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);

            Console.Write("\nBreathe out... ");
            Countdown(6);

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}