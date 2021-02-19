//========================================== Задача №3 ================================================
//   Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
//в) отсортировать список по возрасту студента;
//г) *отсортировать список по курсу и возрасту студента;
//=====================================================================================================

using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    #region класс Student
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public string department;
        public int age;
        public int course;
        public int group;
        public string city;
        public Student
            (string firstName, string lastName,
            string university, string faculty,
            string department, int age, int course,
            int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }
    #endregion

    static void Main ()
    {
        int ageCount = 0;
        int courseCount = 0;
        List<Student> list = new List<Student>();
        StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students.csv");
        while (!sr.EndOfStream)
        {
            string[] s = sr.ReadLine().Split(';');
            list.Add(new Student(s[ 0 ], s[ 1 ], s[ 2 ], s[ 3 ], s[ 4 ], 
                int.Parse(s[ 5 ]), 
                int.Parse(s[ 6 ]), int.Parse(s[ 7 ]), s[ 8 ]));
            if (int.Parse(s[ 5 ]) <= 20)
                ageCount++;
            if (int.Parse(s[ 6 ]) >= 5)
                courseCount++;
        }
        sr.Close();
        list.Sort(new Comparison<Student>(MyDelegate));
        list.Sort(new Comparison<Student>(MyDelegate2));
        Console.WriteLine("Всего студентов:" + list.Count);
        Console.WriteLine("Возраст от 18 до 20: {0}", ageCount);
        Console.WriteLine("На 5 и 6 курсах: {0}", courseCount);

        for (int i = 0; i < list.Count; i++)
        {
            Student v = list[ i ];
            Console.WriteLine($"Имя: {v.firstName} Курс: {v.course} Возраст: {v.age}");
        }
        Console.ReadKey();
    }
    static int MyDelegate (Student st1, Student st2)
    {
        return String.Compare(Convert.ToString(st1.age), Convert.ToString(st2.age));
    }
    static int MyDelegate2 (Student st1, Student st2)
    {
        return String.Compare(Convert.ToString(st1.course), Convert.ToString(st2.course));
    }
}