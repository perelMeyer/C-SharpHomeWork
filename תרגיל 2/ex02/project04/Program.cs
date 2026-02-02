using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static int[] arr = new int[20_000_000];

    // ============================
    // סעיף א:
    // שני תהליכונים ניגשים לאזורים שונים במערך
    // ============================
    static void WorkDifferentAreas()
    {
        Thread t1 = new Thread(() =>
        {
            // t1 עובד על החצי הראשון של המערך
            for (int i = 0; i < arr.Length / 2; i++)
                arr[i]++;
        });

        Thread t2 = new Thread(() =>
        {
            // t2 עובד על החצי השני של המערך
            for (int i = arr.Length / 2; i < arr.Length; i++)
                arr[i]++;
        });

        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
    }

    // ============================
    // סעיף ב:
    // שני תהליכונים ניגשים לכל המערך
    // ============================
    static void WorkSameArea()
    {
        Thread t1 = new Thread(() =>
        {
            // t1 עובר על כל המערך
            for (int i = 0; i < arr.Length; i++)
                arr[i]++;
        });

        Thread t2 = new Thread(() =>
        {
            // t2 גם עובר על כל המערך
            for (int i = 0; i < arr.Length; i++)
                arr[i]++;
        });

        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
    }

    // ============================
    // MAIN — הרצת שני הניסויים
    // ============================
    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        // הרצת סעיף א
        sw.Start();
        WorkDifferentAreas();
        sw.Stop();
        Console.WriteLine("זמן עבודה על אזורים שונים (סעיף א): " + sw.ElapsedMilliseconds + "ms");

        // איפוס המערך
        Array.Clear(arr, 0, arr.Length);

        // הרצת סעיף ב
        sw.Restart();
        WorkSameArea();
        sw.Stop();
        Console.WriteLine("זמן עבודה על כל המערך (סעיף ב): " + sw.ElapsedMilliseconds + "ms");
    }
}

