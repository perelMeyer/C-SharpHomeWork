using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        const int N = 50_000_000;
        int[] arr = new int[N];

        // מילוי המערך (לא חובה, אבל מונע אופטימיזציות קיצוניות)
        for (int i = 0; i < N; i++)
        {
            arr[i] = i;
        }

        // גישה רציפה
        long seqTime = MeasureSequentialAccess(arr);
        Console.WriteLine($"Sequential access: {seqTime} ms");

        // גישה מרוחקת (קפיצות קבועות)
        long sparseTime = MeasureSparseAccess(arr, 1000);
        Console.WriteLine($"Sparse access (step 1000): {sparseTime} ms");
    }

    static long MeasureSequentialAccess(int[] arr)
    {
        Stopwatch sw = Stopwatch.StartNew();
        long sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        sw.Stop();
        // שימוש ב-sum כדי למנוע אופטימיזציה
        if (sum == -1) Console.WriteLine();
        return sw.ElapsedMilliseconds;
    }

    static long MeasureSparseAccess(int[] arr, int step)
    {
        Stopwatch sw = Stopwatch.StartNew();
        long sum = 0;
        for (int i = 0; i < arr.Length; i += step)
        {
            sum += arr[i];
        }
        sw.Stop();
        if (sum == -1) Console.WriteLine();
        return sw.ElapsedMilliseconds;
    }
}
