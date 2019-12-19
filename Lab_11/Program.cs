using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static int size = 5;
        static Random rnd = new Random();

        static void AddEl(ArrayList arr1)
        {
            int a = rnd.Next(1, 4);
            switch(a)
            {
                case 1:
                    arr1.Add(new Region());
                    break;
                case 2:
                    arr1.Add(new Town());
                    break;
                case 3:
                    arr1.Add(new Metropolis());
                    break;
                case 4:
                    arr1.Add(new Adress());
                    break;
            }
        }

        static void AddElD(Dictionary<int,Place> arr)
        {
            int a = rnd.Next(1, 4);
            int key = rnd.Next(-100000, 100000);
            switch (a)
            {
                case 1:
                    arr.Add(key, new Region());
                    break;
                case 2:
                    arr.Add(key, new Town());
                    break;
                case 3:
                    arr.Add(key, new Metropolis());
                    break;
                case 4:
                    arr.Add(key, new Adress());
                    break;
            }
        }

        static int CountRegion(ArrayList arr) // Три запроса
        {
            int res = 0;
            foreach (var cur in arr)
                if (cur is Region)
                    res++;
            return res;
        }

        static void ShowTown(ArrayList arr)
        {
            foreach (var cur in arr)
                if (cur is Town town)
                    town.Show();
        }

        static void CountPeopleMetropolis(ArrayList arr)
        {
            foreach(var cur in arr)
                if (cur is Metropolis metropolis)
                    Console.WriteLine($"{metropolis.cnt_people} человек");
        }


        static int CountRegion(Dictionary<int, Place> arr) // Три запроса
        {
            int res = 0;
            foreach (var cur in arr)
                if (cur.Value is Region)
                    res++;
            return res;
        }

        static void ShowTown(Dictionary<int, Place> arr)
        {
            foreach (var cur in arr)
                if (cur.Value is Town town)
                    town.Show();
        }

        static void CountPeopleMetropolis(Dictionary<int, Place> arr)
        {
            foreach (var cur in arr)
                if (cur.Value is Metropolis metropolis)
                    Console.WriteLine($"{metropolis.cnt_people} человек");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.");
            ArrayList arr1 = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                AddEl(arr1);
            }

            Console.WriteLine("Клонирование коллекции.");
            ArrayList arr2 = (ArrayList)arr1.Clone();

            Console.WriteLine("Сортировка и поиск.");
            Town town = new Town();
            arr1.Insert(1, town);
            arr1.BinarySearch(town);

            Console.WriteLine("Задание 2.");

            Dictionary<int, Place> arr3 = new Dictionary<int, Place>();
            for (int i = 0; i < size; i++)
            {
                AddElD(arr3);
            }

            Console.WriteLine("Сортировка и поиск.");
            arr3.Add(123456, town);
            arr3.ContainsValue(town);

            Console.WriteLine("Задание 3.");
            MyCollection collection = new MyCollection(5);

            Console.WriteLine(collection.Test1Col());
            Console.WriteLine(collection.Test2Col());
            Console.WriteLine(collection.Test3Col());
            Console.WriteLine(collection.Test4Col());

        }
    }
}
