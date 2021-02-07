//====================== Вебинар 5 задача №3 ================================
// Для двух строк написать метод, определяющий, 
// является ли одна строка перестановкой другой.
// Например:
// "badc" являются перестановкой "abcd".
//===========================================================================

using System;

class Program
{
    static void Main ()
    {
        Console.WriteLine("Введите первую строку: ");
        char[] a = Console.ReadLine().ToCharArray();
        Console.WriteLine("Введите вторую строку: ");
        char[] b = Console.ReadLine().ToCharArray();
        if (a.Length == b.Length)
            Reverse(a, b);
        else
            Console.WriteLine("False");
        Console.ReadLine();
    }
    static void Reverse (char[] a, char[] b)
    {
        Array.Sort(a);
        Array.Sort(b);
        int c = 0;
        for (int i = 0; i < b.Length; i++)
        {
            if (a[ i ] == b[ i ])
                c++;
        }
        if (c == b.Length)
            Console.Write("True");
        else
            Console.WriteLine("False");
    }
}