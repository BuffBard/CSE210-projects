using System;

class Program
{
    static void Main(string[] args)
    {
         bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nChoose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new Breathing().WhatItDo();
                    break;

                case "2":
                    new Reflection().WhatItDo();
                    break;

                case "3":
                    new Listening().WhatItDo();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}