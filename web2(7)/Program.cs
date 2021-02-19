// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
//================================================================================

using System;
namespace web2_7_
{
    class Program
    {
        static void PrintNumber (int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                a++;
                PrintNumber(a, b);
            }
        }
        static int SumNumber (int a, int b)
        {
            if (a <= b)
            {
                var sum = SumNumber(a + 1, b);
                return sum + a;
            }
            return 0;
        }
        static void Main ()
        {
            Console.Write("Введите число a: ");
            var d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            var e = Convert.ToInt32(Console.ReadLine());

            PrintNumber(d, e);
            Console.Write($"\nСумма всех чисел равна: { SumNumber(d, e)}");            
            Console.ReadKey();
        }
    }
}