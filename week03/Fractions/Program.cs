using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction(5, 9);

        Console.WriteLine(f.GetFractionString());

        f.SetTopFraction(1);
        Console.WriteLine(f.GetTopFraction());
        Console.WriteLine(f.GetFractionString());

        f.SetBottomFraction(3);
        Console.WriteLine(f.GetBottomFraction());
        Console.WriteLine(f.GetFractionString());

        Console.WriteLine(f.GetDecimalValue());



    }
}