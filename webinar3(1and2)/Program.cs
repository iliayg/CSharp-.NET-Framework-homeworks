//=============================== Вебинар 3 задача №1 ========================
// 1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
//   б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
//   в) Добавить диалог с использованием switch демонстрирующий работу класса.

//================================== Вебинар 3 задача №2 =====================
// С клавиатуры вводятся числа, пока не будет введён 0 
// Требуется подсчитать сумму всех нечётных положительных чисел. 
// Сами числа и сумму вывести на экран, используя tryParse.
//============================================================================

using System;
namespace Webinar3ex1
{
    class Program
    {
        //////////1.а)
        #region 1. a) Cтруктура Complex.
        struct Complex
        {
            public int im;
            public int re;
            public Complex Minus (Complex x)
            {
                Complex y;
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }
            public override string ToString () => $"{re} + {im}i";
        }
        #endregion
        private static void Main ()
        {
            Complex z1;
            z1.re = 2;
            z1.im = -3;

            Complex z2;
            z2.re = 3;
            z2.im = -6;
            Console.WriteLine($"Вычитание через структуру: {z1.Minus(z2)}");  // <-- 1.a)

            //////////1.б)  
            #region 1.б) Класс ComplexClass, методы вычитания и произведения.  
            ComplexClass x = new ComplexClass(2, -3);
            ComplexClass y = new ComplexClass(3, -6);
            Console.WriteLine($"Вычитание через класс: {x.MinusMethod(y)}");
            Console.WriteLine($"Умножение: {x.MultiplyMethod(y)}");
            #endregion

            //////////1.в)
            #region 1.в) switch демонстрирующий работу класса
            Console.WriteLine("Диалог с использованием switch демонстрирующий работу класса:\n" +
                "Выберите действие: - или * ?");
            string action = Console.ReadLine();
            switch (action)
            {
                case "-":
                    Console.WriteLine(x.MinusMethod(y));
                    break;
                case "*":
                    Console.WriteLine(x.MultiplyMethod(y));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            #endregion

            #region Задача №2
            string str = string.Empty;
            int sum = 0;
            Console.WriteLine("Вторая задача:");
            while (true)
            {
                Console.WriteLine("Введите число:");
                int.TryParse(Console.ReadLine(), out int a);
                if (a == 0)
                    break;
                else if (a % 2 == 1 && a > 0)
                    sum += a;
                str += $"{a} ";
            }
            Console.WriteLine($"{str} {sum}");
            #endregion

            Console.ReadLine();
        }
        class ComplexClass
        {
            ComplexClass ()
            {
                Re = 0;
                Im = 0;
            }
            public int Re
            {
                get; set;
            }
            public int Im
            {
                get; set;
            }
            public ComplexClass (int re, int im)
            {
                this.Re = re;
                this.Im = im;
            }
            public ComplexClass MinusMethod (ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.Re = Re - x.Re;
                y.Im = Im - x.Im;
                return y;
            }
            public ComplexClass MultiplyMethod (ComplexClass x)
            {
                ComplexClass z = new ComplexClass();
                z.Im = Re * x.Im + Im * x.Re;
                z.Re = Re * x.Re - Im * x.Im;
                return z;
            }
            public override string ToString () => $"{Re} + {Im}i";
        }
    }
}