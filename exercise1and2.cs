//==================================== Вебинар 1 Задачи №№1 и 2 =======================================
using System;
namespace Webinar1ex1and2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            Console.Write("Введите Фамилию:");
            string surname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int a = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите рост в метрах: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес: ");
            double m = Convert.ToDouble(Console.ReadLine());

            //-----------------------------Первая задача--------------------------------
            // 1. Написать программу «Анкета». 
            //    Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
            #region 1. a) вывод данных используя склеивание: 
            string line = "Имя: " + name + " Фамилия: " + surname + " Возраст: " + a + " Рост: " + h + " Вес: " + m;
            Console.WriteLine('\n' + line + "  - склеивание");
            #endregion                             

            #region 1.б) вывод данных используя форматированный вывод:
            string pattern = "Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}";
            string output = String.Format(pattern,
                                          name,
                                          surname,
                                          a,
                                          h,
                                          m
                                          );
            Console.WriteLine('\n' + output + "  - форматированный вывод");
            #endregion

            #region 1.в) вывод данных используя знак "$":
            string text = $@"Имя: {name}
Фамилия: {surname} 
Возраст: {a} 
Рост: {h} 
Вес: {m}";
            Console.WriteLine('\n' + text +
                "                                    " +
                "- вывод данных используя знак '$'\n");
            #endregion

            //-------------------------------Вторая задача------------------------------
            // 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела.
            double I = m / (h * h);
            Console.WriteLine("Индекс массы тела: " + $"{I:F}");
            Console.ReadLine();
        }
    }
}