using Lab1UniOS;
using System;
using System.Numerics;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лаб 1");

            Complex a = new() { Real = 3, Imag = 0.5 };
            Complex b = new() { Real = 2, Imag = 0.8 };

            a.Add(b);

            b.Subtract(a);

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            Console.WriteLine("Класс студентов");

            Student student1 = new Student("Иван", "Мужчина", "Коричневый", 20);
            Student student2 = new Student("Алиса", "Женщина", "Блонд", 22);
            Student student3 = new Student("Петр", "Мужчина", "Рыжий", 25);

            Console.WriteLine("Информация о студенте 1:");
            Console.WriteLine(student1.ToString());

            Console.WriteLine("Информация о студенте 2:");
            Console.WriteLine(student2.ToString());

            Student sum = Student.AddStudents(student1, student2, student3);
            Console.WriteLine("Результат сложения студентов:");
            Console.WriteLine(sum.ToString());
        }
    }
}