using System;

public delegate double BinaryOperation(double x, double y);

public class Operations
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double ApplyOperation(BinaryOperation bOp, double a, double b)
    {
        return bOp(a, b);
    }


    public static void Main(string[] args)
    {
        double x = 10;
        double y = 4;

        double sum = ApplyOperation(Add, x, y);
        double diff = ApplyOperation(Subtract, x, y);
        double prod = ApplyOperation(Multiply, x, y);

        Console.WriteLine($"Add: {sum}");
        Console.WriteLine($"Subtract: {diff}");
        Console.WriteLine($"Multiply: {prod}");
    }
}
