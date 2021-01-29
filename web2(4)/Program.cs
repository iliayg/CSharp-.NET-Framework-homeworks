//======================== Вебинар 2 Задача №4 =========================================
//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел 
//Логин: root 
//Password: GeekBrains 
//пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
//С помощью цикла do while ограничить ввод пароля тремя попытками.
//======================================================================================

using System;
namespace Webinar2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Authorization(x);
        }

        #region Метод для проверки данных.
        private static int Authorization(int x)
        {
            do
            {
                Console.WriteLine("Please, enter login:");
                string l = Console.ReadLine();
                Console.WriteLine("Please, enter password:");
                string p = Console.ReadLine();
                if (l == "root" && p == "GeekBrains")
                {
                    Console.WriteLine("You are welcome!");
                    break;
                }
                x--;
                Attempts(x);
            }
            while (x > 0);
            return x;
        }
        #endregion

        #region Метод с счётчиком попыток.
        private static void Attempts(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("Try again. You have " + x + " attempts");
            }
            else Console.WriteLine("Denied!");
        }
        #endregion
    }
}