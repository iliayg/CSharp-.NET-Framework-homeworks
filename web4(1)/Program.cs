﻿//======================================= Задача №1 =====================================================
// Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  
// от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, 
// позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
// В данной задаче под парой подразумевается два подряд идущих элемента массива. 
// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
//=======================================================================================================

using System;
namespace web4_1_
{
    class Program
    {
        static void Main ()
        {
            int[] a = new int[ 10 ];
            int count = 0;
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[ i ] = rnd.Next(1, 10);
                Console.WriteLine($"{a[ i ]} ");
            }
            count = NewMethod(a, count);
            Console.WriteLine(count);
            Console.ReadLine();
        }
        private static int NewMethod (int[] a, int count)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[ i ] % 3 == 0 && i < a.Length)
                {
                    i++;
                    if (a[ i ] % 3 != 0) count++;
                }
                else if (a[ i ] % 3 != 0 && i < a.Length)
                {
                    i++;
                    if (a[ i ] % 3 == 0) count++;
                }
            }
            return count;
        }
    }
}