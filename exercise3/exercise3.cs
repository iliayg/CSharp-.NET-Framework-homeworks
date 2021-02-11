//=============================== Вебинар 1 задача №3 ====================================
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
//    y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
// б) Выполнить, оформив вычисления расстояния между точками в виде метода.
// в) Вывести результат,используя спецификатор формата .2f
//========================================================================================
using System;
namespace Webinar1ex3
{
    class Program
    {
        public static double Add(
            double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        private static void Main(string[] args)
        {
            string result = string.Format("{0:f2}", Add(2, 2, 4, 4));
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}