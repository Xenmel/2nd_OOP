using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
			UList list = new UList();
			Region reg = new Region();
			Region clone = (Region)reg.Clone();
			list.Add(clone);
			list.Add(reg);
			list.Add(new Region());
			list.Add(new Region());
			list.Add(new Region());
			list.Add(reg);

			Console.WriteLine("\nВывод списка:");

			foreach (object obj in list)
				Console.WriteLine(obj);

			list.Remove(clone);
			Console.WriteLine("\nУдаление элемента:");

			foreach (object obj in list)
				Console.WriteLine(obj);

			//Console.WriteLine(list.Contains(clone));
			list.Insert(new Region(), 1);

			Console.WriteLine("\nДобавление на позицию:");

			foreach (object obj in list)
				Console.WriteLine(obj);

			list = null;

			UDList dlist = new UDList();
			dlist.Add(reg);
			dlist.Add(new Region());
			dlist.Add(new Region());
			dlist.Add(clone);
			dlist.Add(new Region());


			Console.WriteLine("\nВывод двусвязного списка:");
			foreach (object obj in dlist)
				Console.WriteLine(obj);


			dlist.RemoveOdd();
			Console.WriteLine("\nУдалить четные элементы:");
			foreach (object obj in dlist)
				Console.WriteLine(obj);

			Random rnd = new Random();
			USTree tree = new USTree(0, null);
			tree.Add(rnd.Next(-100,100));
			tree.Add(rnd.Next(-100, 100));
			tree.Add(rnd.Next(-100, 100));
			tree.Add(rnd.Next(-100, 100));
			tree.Add(rnd.Next(-100, 100));
			tree.Add(rnd.Next(-100, 100));
			tree.Add(rnd.Next(-100, 100));
			Console.WriteLine(USTree.Average(tree) + "\n\n");
			tree.Print(0);

			Console.WriteLine("\nДвусвязный стек:");
			MyCollection<Place> collection = new MyCollection<Place>();
			collection.Add(new Region());
			collection.Add(reg);

			foreach (object obj in collection)
				Console.WriteLine(obj);

			Console.WriteLine("\nДвусвязный стек, удаление:");
			collection.Rm();
			foreach (object obj in collection)
				Console.WriteLine(obj);

		}
	}
    
}
