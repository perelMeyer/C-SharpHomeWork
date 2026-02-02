using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Testing array allocation in different sizes...");

        int size = 10_000_000;

        while (true)
        {
            try
            {
                int[] arr = new int[size];
                Console.WriteLine($"Successfully allocated array of size: {size}");
                size *= 2;
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine($"Failed to allocate array of size: {size}");
                break;
            }
        }

        Console.WriteLine("Test completed.");
    }
}
