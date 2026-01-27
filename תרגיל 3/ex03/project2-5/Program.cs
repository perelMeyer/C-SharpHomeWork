using System;

// שלב 2 — מחלקה שמעבדת מערך ומפעילה פעולה על כל איבר
public class ArrayProcessor
{
    // שלב 1 — הגדרת delegate שמקבל double אחד ולא מחזיר ערך
    public delegate void UnaryAction(double value);
    public static void ProcessArray(double[] array, UnaryAction processor)
    {
        foreach (double value in array)
        {
            processor(value); // מפעיל את הפעולה על כל איבר
        }
    }
}

// שלב 3א — מחלקה לחישוב סכום
public class SumCalculator
{
    public double Sum { get; private set; } = 0;

    public void AddToSum(double value)
    {
        Sum += value;
    }
}

// שלב 3ב — מחלקה לחישוב מקסימום
public class MaxCalculator
{
    public double Max { get; private set; } = double.MinValue;

    public void CheckMax(double value)
    {
        if (value > Max)
            Max = value;
    }
}


// שלב 4 + שלב 5 — Main כולל Lambda עם closure
public class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        double[] arr = new double[10];

        for (int i = 0; i < arr.Length; i++)
            arr[i] = rnd.NextDouble() * 100;

        Console.WriteLine("Array:");
        foreach (var x in arr)
            Console.Write(x + " ");
        Console.WriteLine();

        // --- חישוב סכום באמצעות מחלקה ---
        SumCalculator sumCalc = new SumCalculator();
        ArrayProcessor.ProcessArray(arr, sumCalc.AddToSum);
        Console.WriteLine($"Sum (class) = {sumCalc.Sum}");

        // --- חישוב מקסימום באמצעות מחלקה ---
        MaxCalculator maxCalc = new MaxCalculator();
        ArrayProcessor.ProcessArray(arr, maxCalc.CheckMax);
        Console.WriteLine($"Max (class) = {maxCalc.Max}");

        // --- שלב 5: חישוב סכום ומקסימום באמצעות Lambda + closure ---

        double sum = 0;
        double max = double.MinValue;

        ArrayProcessor.ProcessArray(arr, v => sum += v);
        ArrayProcessor.ProcessArray(arr, v =>
        {
            if (v > max)
                max = v;
        });

        Console.WriteLine($"Sum (lambda) = {sum}");
        Console.WriteLine($"Max (lambda) = {max}");
    }
}
