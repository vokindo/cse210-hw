using System;

public class Program
{
    public static void Main()
    {
        // 1. Fraction 1/1 using the no-parameter constructor
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());  // Output: "1/1"
        Console.WriteLine(fraction1.GetDecimalValue());  // Output: 1.0

        // 2. Fraction 5/1 using the single-parameter constructor
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());  // Output: "5/1"
        Console.WriteLine(fraction2.GetDecimalValue());  // Output: 5.0

        // 3. Fraction 3/4 using the two-parameter constructor
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());  // Output: "3/4"
        Console.WriteLine(fraction3.GetDecimalValue());  // Output: 0.75

        // 4. Fraction 1/3 using the two-parameter constructor
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());  // Output: "1/3"
        Console.WriteLine(fraction4.GetDecimalValue());  // Output: 0.3333333333333333
    }
}
