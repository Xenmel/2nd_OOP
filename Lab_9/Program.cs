using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        public static double Val()
        {
            bool f;
            double val;
            do
            {
                f = Double.TryParse(Console.ReadLine(), out val);
            } while (!f);

            return val;
        }

        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите параметр a: ");
            a = Val();

            Console.WriteLine("Введите параметр b: ");
            b = Val();

            Console.WriteLine("Введите параметр c: ");
            c = Val();

            Uravnenie example1 = new Uravnenie(a, b, c);

            Console.WriteLine("Нестатическая функция: ");
            example1.ShowRes();

            Console.WriteLine("Cтатическая функция: ");
            Uravnenie.ShowResStat(example1);

            Console.WriteLine($"Количество созданных объектов: { Uravnenie.Count}\n\n");

            Console.WriteLine("Задание 2. Перегрузки.");
            Uravnenie example2 = new Uravnenie(a, b, c);

            Console.WriteLine("Перегрузкa ++ копия первого объекта:");
            example2++;
            example2.ShowRes();

            Console.WriteLine("Перегрузкa -- первый объект:");
            example1--;
            example1.ShowRes();

            if(example2 != example1)
                Console.WriteLine("Перегрузка '!=' Объекты не равны.");
            else Console.WriteLine("Перегрузка '!=' Объекты равны.");

            if (example2 == example1)
                Console.WriteLine("Перегрузка '==' Объекты равны.");
            else Console.WriteLine("Перегрузка '==' Объекты не равны.");

            Console.WriteLine($"Перегрузка явная (первый объект): {(bool)example1}");

            double f = example1;
            Console.WriteLine($"Перегрузка неявная (первый объект): {f}");


            Console.WriteLine("\n\nЗадание 3. Массив.");
            Mass mass1 = new Mass();
            Mass mass2 = new Mass(5);
            Mass mass3 = new Mass(1, true);

            Console.WriteLine("Конструктор без параметров: ");
            mass1.Show();
            Console.WriteLine("Конструктор с рандомными значениями: ");
            mass2.Show();
            Console.WriteLine("Конструктор с задаваемыми с клавиатуры значениями: ");
            mass3.Show();

            Console.WriteLine($"Количество созданных объектов: { Uravnenie.Count}\n\n");

            Console.WriteLine("Максимальный корень(сумма двух корней).");
            Console.WriteLine($"Массив 1: {mass1.Max()}");
            Console.WriteLine($"Массив 2: {mass2.Max()}");
            Console.WriteLine($"Массив 3: {mass3.Max()}");


        }
    }
}
