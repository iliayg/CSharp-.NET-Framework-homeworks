//Давайте поупражняемся с работой в консоли. Напишем для этого несколько функций, которые будут выводить данные в определённом месте консоли. А также создадим перегрузку метода, в котором можно будет задать цвет символов:

using System;

namespace web1_5_
{
    class Program
    {
        static void Main ()
        {
            string surnameInput = Console.ReadLine();
            string nameInput = Console.ReadLine();
            string cityInput = Console.ReadLine();
            Console.Clear();
            OutputHelpers.PrintInCenter($"{ surnameInput} { nameInput}, г. { cityInput}");
            Console.ReadKey();
        }
        public class OutputHelpers
        {
            public static void PrintInCenter (string text)
            {
                Console.SetCursorPosition(
                    (Console.WindowWidth - text.Length) / 2, 
                    Console.WindowHeight / 2 - 1);
                Console.WriteLine(text);
            }
        }
    }
}