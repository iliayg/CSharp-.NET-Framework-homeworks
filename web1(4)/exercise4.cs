//============= Вебинар 1 задача №4 ===================
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.
//=====================================================

using System;
class Program
{
    //static int Change1(int b)
    //{
    //    int a = b;
    //    Console.WriteLine("a = " + a);
    //    return a;
    //}
    //static int Change2(int a)
    //{
    //    int b = a;
    //    Console.WriteLine("b = " + b);
    //    return b;
    //}
    static void Main()
    {
        int a = 10;
        int b = 20;

        #region Задача "а".
        int t = a;
        a = b;
        b = t;
        Console.WriteLine("a = " + a + "\n" + "b = " + b + "\n");
        #endregion

        //#region Задача "б".
        //a = 10;
        //b = 20;
        //Change1(b);
        //Change2(a);
        //#endregion


        Console.Write("Укажите значение переменной a: ");
        var aInput = int.Parse(Console.ReadLine());
        Console.Write("Укажите значение переменной b: ");
        var bInput = Convert.ToInt32(Console.ReadLine());
        a = aInput;
        b = bInput;

        a += b;
        b = a - b;
        a -= b;

        Console.WriteLine($"(2 переменные) Значение переменной a = {a},  значение переменной b = {b}");
        Console.ReadLine();
    }
}