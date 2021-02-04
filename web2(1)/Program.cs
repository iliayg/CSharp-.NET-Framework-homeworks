//=================== Вебинар 2 Задача № 1.================= 
// Написать метод, возвращающий минимальное из трёх чисел.  
//==========================================================

using System;
namespace Webinar2ex1
{
    class Program
    {
        static void Main ()
        {
            #region Ввод данных от пользователя.
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            #endregion

            int min = Min(a, b, c);
            Console.WriteLine(min + " is the smallest number");

            Console.WriteLine($"Count of digits in the smallest number: {Counter(min)}");
            Console.ReadLine();
        }
        #region Метод, находящий минимальное число.
        static int Min (int a, int b, int c)
        {
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b <= a && b < c)
            {
                min = b;
            }
            else min = c;
            return min;
        }
        #endregion

        #region Написать метод подсчета количества цифр числа.
        static int Counter (int a)
        {
            int count = 1;
            if (9 < a && a < 100) count++;
            else if (99 < a && a < 1000) count = 3;
            else if (999 < a && a < 1000) count = 4;
            return count;
        }
        #endregion
    }
}