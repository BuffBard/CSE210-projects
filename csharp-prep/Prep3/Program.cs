using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        Random randomGenerator = new Random();
        do
        {
            int number = randomGenerator.Next(1, 101);
            bool win=false;
            int guesses=0;
            while (!win)
            {
                Console.Write("\nWhat is your guess? ");
                int userInput=int.Parse(Console.ReadLine());
                guesses+=1;
                if (userInput == number)
                {
                    win=true;
                    Console.WriteLine("You got the correct number in "+guesses+" guesses!");
                }
                else if (userInput > number)
                {
                    Console.WriteLine("The number is Lower.");
                }
                else if (userInput < number)
                {
                    Console.WriteLine("The number is Higher.");
                }
            }
            Console.Write("Would you like to continue('no' to end)? ");
            response=Console.ReadLine();
        }
        while(response!="no");

    }
}