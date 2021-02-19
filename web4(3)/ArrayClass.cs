//=========== Библиотека для задачи Webniar4ex3 =====================
using System;

namespace ArrayClass
{
    public class MyArray
    {
        int[] a;
        public MyArray (int count, int start, int step)
        {
            a = new int[ count ];
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nНаш массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[ i ] = start + (step * i);
                Console.Write($"{a[ i ]} ");
            }
            Console.WriteLine("\nСумма всех элементов: " + Sum);
            Inverse();
            Multi(x);
        }
        #region Свойство Sum
        public int Sum
        {
            get
            {
                int s = a[ 0 ];
                for (int i = 1; i < a.Length; i++)
                    s += a[ i ];
                return s;
            }
        }
        #endregion

        #region Метод Inverse
        private void Inverse ()
        {
            Console.WriteLine("\nИнверсия со знаком '' - '': ");
            for (int i = 0; i < a.Length; i++)
            {
                a[ i ] = -a[ i ];
                Console.Write($"{a[ i ]} ");
            }
        }
        #endregion

        #region Метод Multi
        private void Multi (int x)
        {
            Console.WriteLine('\n');
            Console.WriteLine("Произведение элементов на определённый множитель " + $"({x})");
            for (int i = 0; i < a.Length; i++)
            {
                a[ i ] = a[ i ] * x;
                Console.Write($"{a[ i ]} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Свойство MaxCount
        public int MaxCount
        {
            get
            {
                int max = 0;
                int sum = 0;
                Random rnd = new Random();
                Console.WriteLine("\nРандомный массив:");
                for (int i = 0; i < a.Length; i++)
                {
                    a[ i ] = rnd.Next(0, 9);
                    Console.Write($"{a[ i ]} ");
                    if (a[ i ] > max)
                        max = a[ i ];
                }
                for (int i = 0; i < a.Length; i++)
                    if (a[ i ] == max)
                        sum++;
                Console.Write($"\nМаксимальных элементов: ");
                return sum;
            }
        }
        #endregion
    }
}