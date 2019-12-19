using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {

        static void Main(string[] args)
        {
            //bool f;
            //int size;

            Console.WriteLine("Задание 1."); 

            Region reg = new Region();
            Town town = new Town();
            Metropolis metropolis = new Metropolis();
            Adress adress = new Adress();

            Place[] arr = { reg, town, metropolis, adress };

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i].Show();
            }

            Console.WriteLine("\n\nЗадание 2.");

            Console.WriteLine("\nКоличество женщин:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}-й элемент: {arr[i].cnt_woman} женщин");
            }

            Console.WriteLine("\nСуммарное количество жителей всех городов в области:");
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] is Region)
                {
                    Console.WriteLine($"{i}-й элемент: {arr[i].AllPeople()} жителей в области"); 
                }
            }

            Console.WriteLine("\nФИО мера города:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Town || arr[i] is Metropolis)
                {
                    arr[i].GetMer();
                }
            }


            Console.WriteLine("\n\nЗадание 3.");

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i].Show();
            }

            Console.WriteLine("\n\nКлонирование объектов Region:");
            Region[] arr2 = new Region[5];
            for(int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = (Region)reg.Clone();
                arr2[i].Show();
            }



            Console.WriteLine("\n\nСортировка по количеству людей ICompare:");
            Array.Sort(arr, new CntPeople());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Show();
            }

            Console.WriteLine("\n\nСортировка по количеству людей IComparable клонированного массива:");
            Array.Sort(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i].Show();
            }
        }
    }
}
