//======================================= Задача №2 ===============================================
//    Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б)*Добавьте статический метод для считывания массива из текстового файла. 
//    Метод должен возвращать массив целых чисел;
//*в)*Добавьте обработку ситуации отсутствия файла на диске.
//=================================================================================================

using System;
using System.IO;
namespace web4_1_
{

    #region Задача №2.а)
    public static class StaticClass
    {
        public static int MyArray (int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[ i ] % 3 == 0 && i < a.Length)
                {
                    i++;
                    if (a[ i ] % 3 != 0)
                        count++;
                }
                else if (a[ i ] % 3 != 0 && i < a.Length)
                {
                    i++;
                    if (a[ i ] % 3 == 0)
                        count++;
                }
            }
            return count;
        }
    }
    #endregion

    class Program
    {
        static void Main ()
        {
            //string file = "";
            //Console.WriteLine(IfFileExists(file));

            #region Часть из первой задачи.
            int[] a = new int[ 20 ];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[ i ] = rnd.Next(-10000, 10000);
                Console.WriteLine($"{a[ i ]} ");
            }
            Console.WriteLine(StaticClass.MyArray(a));
            Console.WriteLine();
            #endregion

            #region Задача 2.б)
            int[] b = ArrayFromFile(AppDomain.CurrentDomain.BaseDirectory + "TextFile1.txt");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("{0} ", b[ i ]);
            }
            #endregion

            Console.ReadLine();
        }

        static int[] ArrayFromFile (string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);
                int[] a = new int[ int.Parse(reader.ReadLine()) ];
                for (int i = 0; i < a.Length; i++)
                    if (int.TryParse(reader.ReadLine(), out int e))
                        a[ i ] = e;
                    else
                        a[ i ] = 0;
                reader.Close();
                return a;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        // чтоб сработала остальная часть кода
        // я закомментировал этот метод
        #region Задача 2.в)
        //static bool IfFileExists (string fileName)
        //{
        //    if (File.Exists(fileName))
        //        return true;
        //    else
        //        throw new FileNotFoundException("file not found");
        //}
        #endregion
    }
}