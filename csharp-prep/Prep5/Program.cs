using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name=Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number=int.Parse(Console.ReadLine());
            return number;
        }
        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("What is your birth year? ");
            birthYear=int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int numToSquare)
        {
            return numToSquare*numToSquare;
        }
        static void DisplayResult(string name, int squaredNumber, int birthyear)
        {
            Console.WriteLine($"{name}your number squared: {squaredNumber}");
            Console.WriteLine($"{name} this year you will turn {2026-birthyear} years old.");
        }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name=PromptUserName();
        int number=PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int numberSquared=SquareNumber(number);
        DisplayResult(name, numberSquared, birthYear);
    }
}