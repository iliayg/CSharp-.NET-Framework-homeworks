//============================== Вебинар 2 задача №5 ====================================
//5. а) Написать программу, которая запрашивает массу и рост человека, 
//      вычисляет его индекс массы и сообщает, 
//      нужно ли человеку похудеть, набрать вес или всё в норме.
//   б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
//=======================================================================================

using System;
namespace Webinar2ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост в метрах (#.##): ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес в килограммах: ");
            double m = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);
            Console.Write("Ваш индекс массы тела: " + $"{I:F}, ");
            Check(h, I);
        }

        #region Проверка индекса на соответсвтие норме и вывод результата.
        static void Check(double h, double I)
        {
            if (I > 25)
            {
                double kgdwn = (I - 25) * (h * h);
                Console.Write("Вам нужно сбросить " + $"{kgdwn:f2}" + " кг");
            }
            else if (I < 18.5)
            {
                double kgup = (18.5 - I) * (h * h);
                Console.Write("Вам нужно набрать " + $"{kgup:f2}" + " кг");
            }
            else Console.WriteLine("Всё в норме!");
        }
        #endregion
    }
}