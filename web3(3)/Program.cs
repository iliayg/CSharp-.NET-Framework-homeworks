//   *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
//    Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
//    Написать программу, демонстрирующую все разработанные элементы класса.
//   *Добавить свойства типа int для доступа к числителю и знаменателю;
//   *Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//  **Добавить проверку, чтобы знаменатель не равнялся 0. 
//    Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
// ***Добавить упрощение дробей.
//==========================================================================================
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main ()
        {
            Fraction frac1 = new Fraction(15, 16);
            Fraction frac2 = new Fraction(7, 8);
            Console.WriteLine($"Работа с дробями: {frac1} и {frac2}");
            Fraction sum = frac1.Plus(frac2);
            Console.WriteLine(string.Format("Сумма в десятичном формате: {0:f2}", sum.GetFraction));
            Console.WriteLine(sum);
            Console.WriteLine(frac1.Minus(frac2));
            Console.WriteLine(frac1.Multi(frac2));
            Console.ReadKey();
        }
        class Fraction
        {
            private int _numerator;
            private int _denominator;
            public int Numerator
            {
                get
                {
                    return _numerator;
                }
                set
                {
                    value = _numerator;
                }
            }
            public int Denominator
            {
                get
                {
                    return _denominator;
                }
                set
                {
                    if (value == 0)
                        throw new ArgumentException("Знаменатель не может быть равен 0");
                    value = _denominator;
                }
            }
            public double GetFraction
            {
                get
                {
                    return (double)_numerator / _denominator;
                }
            }
            public Fraction (int numerator, int denominator)
            {
                if (denominator <= 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                _numerator = numerator;
                _denominator = denominator;
                // Автоматическая нормализация дроби (при необходимости)
                Nod();
            }
            public Fraction Plus (Fraction f)
            {
                var den = _denominator * f.Denominator;
                var num = _numerator * f.Denominator + f.Numerator * Denominator;
                return new Fraction(num, den);
            }
            public Fraction Minus (Fraction f)
            {
                var den = _denominator * f.Denominator;
                var num = _numerator * f.Denominator - f.Numerator * Denominator;
                return new Fraction(num, den);
            }
            public Fraction Multi (Fraction f)
            {
                var den = _denominator * f.Denominator;
                var num = _numerator * f.Numerator;
                return new Fraction(num, den);
            }
            private void Nod ()
            {
                var num = Math.Abs(_numerator);
                var den = Math.Abs(_denominator);
                int temp;

                while (num != 0 && den != 0)
                {
                    if (num % den > 0)
                    {
                        temp = num;
                        num = den;
                        den = temp % den;
                    }
                    else
                        break;
                }

                if (num != 0 && den != 0)
                {
                    _numerator = _numerator / den;
                    _denominator = _denominator / den;
                }
            }
            public override string ToString ()
            {
                Nod();
                return $"{_numerator}/{_denominator}";
            }
        }
    }
}