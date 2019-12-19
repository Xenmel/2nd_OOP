using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {     static void Print(Collection list, Collection list1)
        {
            Console.WriteLine("\nСписок 1:");
            foreach (var cur in list)
            {
                Console.WriteLine(cur);
            }
            Console.WriteLine("\nСписок 2:");
            foreach (var cur in list1)
            {
                Console.WriteLine(cur);
            }
        }

        static void Main(string[] args)
        {
            Collection list = new Collection();
            Collection list1 = new Collection();

            Journal journal = new Journal();
            Journal journal1 = new Journal();

            journal.SubOnColChanged(list);
            journal.SubOnRefChanged(list);

            journal1.SubOnRefChanged(list1);
            journal1.SubOnRefChanged(list);

            list.Add(new Region());
            list.Add(new Region());
            list.Add(new Region());
            list.Add(new Region());
            list.Add(new Region());

            list1.Add(new Region());
            list1.Add(new Region());
            list1.Add(new Region());
            list1.Add(new Region());
            list1.Add(new Region());

            Print(list,list1);

            Console.WriteLine("\nУдаление:");
            list.Remove(2);
            list1.Remove(3);
            Print(list, list1);

            //Console.WriteLine("\nИзменение:");
            //list[0] = new MyCollection<Place>.Node(new Region());
            //list1[1] = new MyCollection<Place>.Node(new Region());
            //Print(list, list1);

            Console.WriteLine("\nЖурнал 1:");
            foreach (var cur in journal)
                Console.WriteLine(cur);

            Console.WriteLine("\nЖурнал 2:");
            foreach (var cur in journal1)
                Console.WriteLine(cur);

        }
    }
}
