using System;

// 1. הגדרת delegate מותאם אישית
public delegate int OperationDelegate(int a, int b);

// 2. מחלקה שיוצרת לוח פעולה
public class OperationTable
{
    private int startRow;
    private int endRow;
    private int startCol;
    private int endCol;

    // 3. משתנה שמחזיק מצביע לפונקציה
    private OperationDelegate op;

    // 4. בנאי שמקבל טווחים ואת הפעולה
    public OperationTable(int startRow, int endRow,
                          int startCol, int endCol,
                          OperationDelegate op)
    {
        this.startRow = startRow;
        this.endRow = endRow;
        this.startCol = startCol;
        this.endCol = endCol;
        this.op = op;   // שמירת הפונקציה בתוך האובייקט
    }

    // 5. הדפסת לוח הפעולה
    public void Print()
    {
        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j <= endCol; j++)
            {
                int result = op(i, j);   // הפעלת הפונקציה
                Console.Write(result.ToString().PadLeft(5));
            }
            Console.WriteLine();
        }
    }
}

// 6. דוגמת שימוש
public class Program
{
    public static void Main()
    {
        // פעולה: כפל
        OperationDelegate multiply = (a, b) => a * b;

        // יצירת לוח פעולה
        OperationTable table = new OperationTable(1, 10, 1, 10, multiply);

        // הדפסה
        table.Print();


    }
}
