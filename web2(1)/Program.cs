//=================== Вебинар 2 Задача № 1.================= 
// Написать метод, возвращающий минимальное из трёх чисел.  
//==========================================================

using System;
namespace Webinar2ex1
{
    class Program
    {
        static void Main(string[] args)
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
        }
        #region Метод, находящий минимальное число.
        static int Min(int a, int b, int c)
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
    }
}