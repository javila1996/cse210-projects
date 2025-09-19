using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine("Fraction1 (default): " + fraction1.GetFractionString() +
                          " = " + fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine("Fraction2 (6/1): " + fraction2.GetFractionString() +
                          " = " + fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine("Fraction3 (6/7): " + fraction3.GetFractionString() +
                          " = " + fraction3.GetDecimalValue());

        fraction1.SetNumerator(3);
        fraction1.SetDenominator(4);
        Console.WriteLine("Fraction1 after update: " + fraction1.GetFractionString() +
                          " = " + fraction1.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine("Fraction4 (1/3): " + fraction4.GetFractionString() +
                          " = " + fraction4.GetDecimalValue());
    }
}