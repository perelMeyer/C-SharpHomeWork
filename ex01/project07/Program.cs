// See https://aka.ms/new-console-template for more information
using System;

struct PointStruct
{
    public int X;
    public int Y;
}

class Program
{
    static int counter = 0;

    static void Recursion()
    {
        // אפשר לשנות את גודל המערך לצורך הניסוי
        int[] arr = new int[10];

        // אפשר לשנות את מספר המשתנים המקומיים
        PointStruct p1, p2, p3, p4;
        PointStruct p5, p6, p7, p8;

        counter++;
        Console.WriteLine($"counter = {counter}");

        Recursion(); // קריאה רקורסיבית אינסופית
    }

    static void Main()
    {
        Recursion();
    }
}
