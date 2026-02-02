// See https://aka.ms/new-console-template for more information
using System;

namespace project03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //זה סעיפים שלא הייתי צריכה להגיש אבל רציתי לראות שזה עובד
            // אבל הקובץ הזה במקרה לא מריץ אז אני אשים את זה פה בתור הערה
        }

    }
}

/* זה סעיף 2

string s1 = "hello";
string s2 = s1;
s1 += " world";
Console.WriteLine($"s1={s1}, s2={s2}"); */

/* זה סעיף 3

int[] a = { 1, 2, 3 };
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}
a = ExpandArray(a);

Console.WriteLine();
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}


static int[] ExpandArray(int[] array)
{
int[] newArray = new int[array.Length * 2];

for (int i = 0; i < array.Length; i++)
{
    newArray[i] = array[i];
    newArray[i + array.Length] = array[i];
}

return newArray;
} */

// זה סעיף 5

// int number = 10;
// long factorial = Math.Factorial(number);
// Console.WriteLine($"{number}!={factorial}");

// }

/* class Math
  {
      static public long Factorial(int number)
      {
          long result = 1;
          for (; number >= 1; number--)
          {
              result *= number;
          }
          return result;
      }

  }*/