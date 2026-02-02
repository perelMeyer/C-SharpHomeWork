using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        // 1. בניית רשימת השברים 1/12 עד 12/12
        List<Fraction> values = new List<Fraction>();
        for (int i = 1; i <= 12; i++)
        {
            values.Add(new Fraction(i, 12));
        }

        // 2. הגדרת delegate לפעולת חיבור בין שני שברים
        GenericOperationTable<Fraction>.OpFunc addOp =
            (a, b) => a + b;

        // 3. יצירת טבלת פעולה גנרית של שברים
        GenericOperationTable<Fraction> table =
            new GenericOperationTable<Fraction>(values, values, addOp);

        // 4. הדפסת הטבלה
        table.Print();
    }
}
