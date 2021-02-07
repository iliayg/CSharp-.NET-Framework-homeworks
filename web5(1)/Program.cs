// ================================= Вебинар 5 задача №4 (ЕГЭ №4) ===============================
// На вход программе подаются сведения о сдаче экзаменов учениками. 
// В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
// каждая из следующих N строк имеет следующий формат: 
// < Фамилия > < Имя > < оценки >, где 
// < Фамилия > — строка, из 20 символов, 
// <Имя> — строка, из 15 символов, 
// <оценки> — три целых числа, по пятибалльной системе. 
// <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены пробелом. 
// Пример входной строки: Иванов Петр 4 5 3
// Написать программу, которая будет выводить на экран фамилии и имена трёх худших 
// по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же балл, 
// что и один из худших, вывести их фамилии и имена.
// ==============================================================================================

using System;
using System.IO;

namespace Webinar5ex4
{
    class Program
    {
        struct User
        {
            public string surname;
            public string name;
            public string rating;
            public double average;
            public double x;
            public double y;
            public double z;
        }
        static void Main ()
        {
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "data.txt");
            int N = int.Parse(sr.ReadLine());
            var users = new User[ N ];
            for (int i = 0; i < N; i++)
            {
                var user = sr.ReadLine();
                var fi = user.Split(' ');
                users[ i ].surname = fi[ 0 ];
                users[ i ].name = fi[ 1 ];
                users[ i ].rating = string.Format($"{fi[ 2 ]} {fi[ 3 ]} {fi[ 4 ]}");
                users[ i ].x = Convert.ToInt32(fi[ 2 ]);
                users[ i ].y = Convert.ToInt32(fi[ 3 ]);
                users[ i ].z = Convert.ToInt32(fi[ 4 ]);
                users[ i ].average = (users[ i ].x + users[ i ].y + users[ i ].z) / 3;
            }
            double min;
            for (int i = 1; i < N; i++)
            {
                if (users[ i ].average < users[ 0 ].average)
                {
                    min = users[ i ].average;
                    Console.WriteLine(string.Format
                            ("{0} {1} {2} \n" +
                            "Средний балл: {3:f2}\n",
                            users[ i ].surname,
                            users[ i ].name,
                            users[ i ].rating,
                            min));
                }
            }
            Console.ReadKey();
        }
    }
}