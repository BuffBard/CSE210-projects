using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.ShowFraction());
        Console.WriteLine(f1.ShowDecimal());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.ShowFraction());
        Console.WriteLine(f2.ShowDecimal());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.ShowFraction());
        Console.WriteLine(f3.ShowDecimal());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.ShowFraction());
        Console.WriteLine(f4.ShowDecimal());

        Random random= new Random();
        Fraction f5 = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            f5.SetTop(topValue);
            f5.SetBottom(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f5.ShowFraction()}");
            Console.WriteLine($" Number: {f5.ShowDecimal()}");
        }
    }
}