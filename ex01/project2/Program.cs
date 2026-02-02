// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    public static void MeasureIntArray()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        int[] arr = new int[10000]; 

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"Int array (10000): {after - before} bytes");
    }

    public static void MeasureDoubleArray()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        double[] arr = new double[10000];

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"Double array (10000): {after - before} bytes");
    }

    public static void MeasureStringArray()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        string[] arr = new string[10000];

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"String array (10000): {after - before} bytes");
    }

    struct SmallStruct
    {
        public int X;
    }

    public static void MeasureSmallStructArray()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        SmallStruct[] arr = new SmallStruct[10000];

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"Small struct array: {after - before} bytes");
    }

    struct LargeStruct
    {
        public long A, B, C, D;
    }

    public static void MeasureLargeStructArray()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        LargeStruct[] arr = new LargeStruct[10000];

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"Large struct array: {after - before} bytes");
    }

    class SmallClass
    {
        public int A;
    }

    public static void MeasureSmallClassArray()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        SmallClass[] arr = new SmallClass[10000]; // רק מצביעים

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"SmallClass array (references only): {after - before} bytes");
    }

    public static void MeasureSmallClassObjects()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        SmallClass[] arr = new SmallClass[10000];
        for (int i = 0; i < arr.Length; i++)
            arr[i] = new SmallClass();

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"SmallClass objects: {after - before} bytes");
    }

    class LargeClass
    {
        public int A;
        public int B;
        public int C;
        public int D;
    }

    public static void MeasureLargeClassArray()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        LargeClass[] arr = new LargeClass[10000];

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"LargeClass array (references only): {after - before} bytes");
    }

    public static void MeasureLargeClassObjects()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();

        LargeClass[] arr = new LargeClass[10000];
        for (int i = 0; i < arr.Length; i++)
            arr[i] = new LargeClass();

        long after = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine($"LargeClass objects: {after - before} bytes");
    }


    static void Main(string[] args)
    {

        MeasureIntArray();
        MeasureDoubleArray();
        MeasureStringArray();
        MeasureSmallStructArray();
        MeasureLargeStructArray();
        MeasureSmallClassArray();
        MeasureLargeClassArray();
        MeasureSmallClassObjects();
        MeasureLargeClassObjects();

    }



}

