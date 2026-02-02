using System;
using System.Collections.Generic;

public class OperationTable<T>
{
    public delegate T OpFunc(T x, T y);

    private List<T> rowValues;
    private List<T> colValues;
    private T[,] table;
    private OpFunc op;

    public OperationTable(List<T> _row_values, List<T> _col_values, OpFunc _op)
    {
        rowValues = _row_values;
        colValues = _col_values;
        op = _op;

        int rows = rowValues.Count;
        int cols = colValues.Count;

        table = new T[rows, cols];

        // חישוב הטבלה
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                table[i, j] = op(rowValues[i], colValues[j]);
            }
        }
    }

    public void Print()
    {
        // הדפסת כותרות העמודות
        Console.Write("\t");
        foreach (var col in colValues)
        {
            Console.Write(col + "\t");
        }
        Console.WriteLine();

        // הדפסת כל שורה
        for (int i = 0; i < rowValues.Count; i++)
        {
            Console.Write(rowValues[i] + "\t");

            for (int j = 0; j < colValues.Count; j++)
            {
                Console.Write(table[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
}
public class Program
{
    public static void Main()
    {
        List<double> row_values = new List<double>();
        for (int i = 2; i <= 4; i++)
        {
            row_values.Add(1.0 / i);
        }

        List<double> col_values = new List<double>();
        for (int i = 2; i <= 4; i++)
        {
            col_values.Add(1.0 / i);
        }

        OperationTable<double> t1 =
            new OperationTable<double>(row_values, col_values, (x, y) => x + y);

        t1.Print();
    }
}


