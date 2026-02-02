using System;

public class Fraction
{
    public int Numerator { get; private set; }     // מונה
    public int Denominator { get; private set; }   // מכנה

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero");

        Numerator = numerator;
        Denominator = denominator;

        Reduce();   // צמצום אוטומטי
    }

    // צמצום השבר
    private void Reduce()
    {
        int g = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        Numerator /= g;
        Denominator /= g;

        // שמירה על סימן במונה בלבד
        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    // אלגוריתם gcd
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // + חיבור
    public static Fraction operator +(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Denominator + b.Numerator * a.Denominator,
            a.Denominator * b.Denominator
        );
    }

    // - חיסור
    public static Fraction operator -(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Denominator - b.Numerator * a.Denominator,
            a.Denominator * b.Denominator
        );
    }

    // * כפל
    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Numerator,
            a.Denominator * b.Denominator
        );
    }

    // / חילוק
    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Numerator * b.Denominator,
            a.Denominator * b.Numerator
        );
    }

    // == השוואת שוויון
    public static bool operator ==(Fraction a, Fraction b)
    {
        return a.Numerator == b.Numerator &&
               a.Denominator == b.Denominator;
    }

    public static bool operator !=(Fraction a, Fraction b)
    {
        return !(a == b);
    }

    // < ו >
    public static bool operator <(Fraction a, Fraction b)
    {
        return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
    }

    public static bool operator >(Fraction a, Fraction b)
    {
        return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Fraction f)
            return this == f;
        return false;
    }

    public override int GetHashCode()
    {
        return Numerator.GetHashCode() ^ Denominator.GetHashCode();
    }
}

public class Program
{
    public static void Main()
    {
        Fraction f1 = new Fraction(1, 2);   // 1/2
        Fraction f2 = new Fraction(1, 3);   // 1/3

        Console.WriteLine(f1 + f2);   // 5/6
        Console.WriteLine(f1 - f2);   // 1/6
        Console.WriteLine(f1 * f2);   // 1/6
        Console.WriteLine(f1 / f2);   // 3/2

        Console.WriteLine(f1 > f2);   // True
        Console.WriteLine(f1 == new Fraction(2, 4)); // True (מצומצם ל־1/2)
    }
}
