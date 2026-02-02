// See https://aka.ms/new-console-template for more information
using System;

class MyClass
{
    public int Value;
}

struct MyStruct
{
    public int Value;
}

class Program
{
    static void Main(string[] args)
    {
        // --- חלק א: השמה בין משתנים ---
        Console.WriteLine("=== assignment between variables ===");

        // Class מועבר בהשמה לפי reference
        MyClass c1 = new MyClass { Value = 10 };
        MyClass c2 = c1; // c2 מצביע לאותו אובייקט כמו c1
        c2.Value = 20;
        Console.WriteLine($"c1.Value = {c1.Value}"); // יציג 20
        Console.WriteLine($"c2.Value = {c2.Value}"); // יציג 20

        // Struct מועבר בהשמה לפי value
        MyStruct s1 = new MyStruct { Value = 10 };
        MyStruct s2 = s1; // s2 הוא עותק עצמאי
        s2.Value = 20;
        Console.WriteLine($"s1.Value = {s1.Value}"); // יציג 10
        Console.WriteLine($"s2.Value = {s2.Value}"); // יציג 20

        // --- חלק ב: העברה לפונקציה ---
        Console.WriteLine("\n=== passing arguments to a function ===");

        ChangeClass(c1);
        Console.WriteLine($"c1.Value after function = {c1.Value}"); // יציג 999

        ChangeStruct(s1);
        Console.WriteLine($"s1.Value after function = {s1.Value}"); // עדיין 10

        // --- חלק ג: העברת struct כ-reference ---
        Console.WriteLine("\n=== passing a struct by reference ===");

        ChangeStructByRef(ref s1);
        Console.WriteLine($"s1.Value after function with ref = {s1.Value}"); // יציג 999
    }

    static void ChangeClass(MyClass obj)
    {
        obj.Value = 999; // משנה את האובייקט המקורי
    }

    static void ChangeStruct(MyStruct obj)
    {
        obj.Value = 999; // משנה רק את העותק המקומי
    }

    static void ChangeStructByRef(ref MyStruct obj)
    {
        obj.Value = 999; // משנה את המשתנה המקורי בזכות ref
    }
}

