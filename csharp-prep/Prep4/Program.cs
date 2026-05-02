using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers=[];
        int userInput;
        do{
            Console.Write("Add number to list(0 to stop): ");
            userInput=int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        while(userInput!=0);
        int sum=0;
        foreach(int num in numbers)
        {
            sum+=num;
        }
        double average=((double)sum)/numbers.Count();
        int max=numbers.Max();
        Console.WriteLine("The sum is: "+sum);
        Console.WriteLine("The average is: "+average);
        Console.WriteLine("The largest number is: "+max);
    }
}