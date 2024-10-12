using System;

public class Fraction
{
    // Private fields for encapsulation
    private int numerator;  // Represents the top number of the fraction
    private int denominator;  // Represents the bottom number of the fraction

    // Constructor with no parameters (defaults to 1/1)
    public Fraction()
    {
        // Default fraction is 1/1
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter (numerator only, denominator defaults to 1)
    public Fraction(int numerator)
    {
        // Set the numerator, denominator defaults to 1
        this.numerator = numerator;
        this.denominator = 1;
    }

    // Constructor with two parameters (numerator and denominator)
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;

        // Ensure denominator is not zero to avoid division by zero errors
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.denominator = denominator;
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for numerator
    public void SetNumerator(int value)
    {
        numerator = value;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for denominator with validation to avoid zero
    public void SetDenominator(int value)
    {
        if (value == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        denominator = value;
    }

    // Method to return the fraction as a string (fractional view)
    public string GetFractionString()
    {
        // Return the fraction as "numerator/denominator"
        return $"{numerator}/{denominator}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        // Return the fraction as a decimal by dividing numerator by denominator
        return (double)numerator / denominator;
    }
}
