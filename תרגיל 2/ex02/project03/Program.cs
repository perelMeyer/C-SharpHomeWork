using System;

class Program
{
    // א. החלפת שני איברים במערך לפי אינדקסים
    public static void SwapInArray(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    // ב. פונקציה שמחליפה שני משתנים מאותו טיפוס (ללא Generics)
    public static void SwapInt(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // ג. MAIN שמדגים שימוש
    static void Main(string[] args)
    {
        // דוגמה 1: החלפת איברים במערך
        int[] numbers = { 10, 20, 30, 40 };
        Console.WriteLine("לפני ההחלפה במערך: " + string.Join(", ", numbers));

        SwapInArray(numbers, 1, 3);

        Console.WriteLine("אחרי ההחלפה במערך: " + string.Join(", ", numbers));


        // דוגמה 2: החלפת שני משתנים רגילים
        int x = 5;
        int y = 9;

        Console.WriteLine($"\nלפני ההחלפה: x = {x}, y = {y}");

        SwapInt(ref x, ref y);

        Console.WriteLine($"אחרי ההחלפה: x = {x}, y = {y}");
    }
} 