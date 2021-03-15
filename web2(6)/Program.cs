// Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
// «Хорошим» называется число, которое делится на сумму своих цифр. 
// Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
//==========================================================================================

using System;
namespace web2_6_
{
    class Program
    {
        static void Main ()
        {
            Console.WriteLine($"Производится подсчет количества хороших чисел.\nЭто может занять несколько минут ...");
            DateTime start = DateTime.Now;
            int counter = 0;
            int sum = 0;
            var maxNumber = 1_000_000_000;
            for (int i = 1; i <= maxNumber; i++)
            {
                if (i % GetSum(i) == 0)
                {
                    counter++;
                    sum += i;
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Количество хороших чисел в диапазоне от 1 до {maxNumber} равно {counter}, сумма: {sum}");
            Console.WriteLine($"Подсчет занял у нас {finish - start}");
            Console.ReadKey();
        }
            static int GetSum (int number) 
            {
                var sum = 0;   
                while (number > 0)  
                {
                    sum += number % 10;
                    number /= 10; 
                }
                return sum; 
            }
    }
}