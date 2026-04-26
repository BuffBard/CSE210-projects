using System;

class Program
{
    static void Main(string[] args)
    {
        bool pass=false;
        string letterGrade="";
        Console.Write("Please enter your grade as a whole number: ");
        int numberGrade=Convert.ToInt32(Console.ReadLine());
        if (numberGrade >= 90)
        {
            pass=true;
            letterGrade="A";
        }
        else if (numberGrade >= 80&&numberGrade<90)
        {
            pass=true;
            letterGrade="B";
        }
        else if (numberGrade >= 70&&numberGrade<80)
        {
            pass=true;
            letterGrade="C";
        }
        else if (numberGrade >= 60&&numberGrade<70)
        {
            letterGrade="D";
        }
        else
        {
            letterGrade="F";
        }
            Console.WriteLine($"Your grade is {letterGrade}.");

        if (pass)
        {
            Console.WriteLine("You have passed the class!");
        }
        else
        {
            Console.WriteLine("You have failed the class.");
            
        }
    }
}