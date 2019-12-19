using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Country
    {
        public string Name { get; set; }
        public List<Place> places = new List<Place>();

        public Country(string name)
        {
            int size = Program.rnd.Next(5, 10);
            Name = name;
            for (int i = 0; i < size; i++)
                places.Add(new Region());
        }
    }
 
    class Program
    {
        static List<Country> continent = new List<Country>();
        static public Random rnd = new Random();

        static void Main(string[] args)
        {
            
            continent.Add(new Country("Россия"));
            continent.Add(new Country("Белоруссия"));
            continent.Add(new Country("Китай"));
            continent.Add(new Country("Корея"));

            foreach (var cur in continent)
            {
                Console.WriteLine(cur.Name + ": ");
                foreach (var item in cur.places)
                {
                    Console.WriteLine(item);
                }
            }
                

            Console.WriteLine("\nВыборка данных. Регионы в которых больше 5000 тыс. человек: ");
           
            foreach (var cur in ExpSelect())
                Console.WriteLine(cur);

            Console.WriteLine("\nПолучение счётчика. Количество женщин на континенте: ");

            Console.WriteLine(ExpCnt());

            Console.WriteLine("\nОперации над множествами. Все континенты с количеством городов >1000 в стране Россия: ");

            foreach (var cur in LinqMany())
                Console.WriteLine(cur);

            Console.WriteLine("\nАгрегирование данных. Область с минимальным количеством людей: ");

            Console.WriteLine(ExpMin());


        }

        static IEnumerable LinqSelect()
        {
            return from country in continent
                   from place in country.places
                   where place is Region
                   where (place as Region).cnt_people > 5000
                   select place;
        }

       static  IEnumerable ExpSelect()
        {
            return continent.SelectMany(x => x.places.Where(p => p is Region).Where(p => (p as Region).cnt_people > 2000));
        }

        static int LinqCnt()
        {
            return (from country in continent
                    from place in country.places
                    where place is Region
                    select place.cnt_people).Sum();
        }

        static int ExpCnt()
        {
            return (continent.SelectMany(x => x.places.Where(p => p is Region).Select(p => p.cnt_people))).Sum();
        }

        static IEnumerable LinqMany()
        {
            return (from country in continent
                    where country.Name == "Россия"
                    from place in country.places
                    where place is Region
                    select place).Intersect(from country in continent
                                              from place in country.places
                                              where place is Region
                                              where (place as Region).cnt_people > 1000
                                              select place);
        }

        //static IEnumerable ExpMany()
        //{

        //}

        static int LinqMin()
        {
            return (from country in continent
                   from place in country.places
                   where place is Region
                   select place.cnt_people).Min();
        }

        static int ExpMin()
        {
            return (continent.SelectMany(x => x.places.Where(p => p is Region).Select(p => p.cnt_people))).Min();
        }
    }
}
