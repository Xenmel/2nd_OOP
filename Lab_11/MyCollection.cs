using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_11
{
    class MyCollection
    {
		Stopwatch timer = new Stopwatch();
		Random rnd = new Random();

		List<Place> c1;
        List<string> c2;
        SortedDictionary<Place, Region> c3;
        SortedDictionary<string, Region> c4;

        public MyCollection(int size)
        {
            c1 = new List<Place>(size);
            c2 = new List<string>(size);
            c3 = new SortedDictionary<Place, Region>();
            c4 = new SortedDictionary<string, Region>();

            Region reg;
            for(int i = 0; i < size; i++)
            {
                reg = new Region();
                c1.Add(reg);
                c2.Add(reg.ToString());
                c3.Add(reg.BasePlace, reg);
                c4.Add(reg.ToString(), reg);
            }
        }

		public string Test1Col()
		{
			return Test1() + Test2() + Test3() + Test4();
		}
		public string Test2Col()
		{
			return Test5() + Test6() + Test7() + Test8();
		}
		public string Test3Col()
		{
			return Test9() + Test10()+ Test11() + Test12();
		} 
		public string Test4Col()
		{
			return Test13() + Test14() + Test15() + Test16() + Test17() + Test18() + Test19() + Test20();
		}

		public string Test1()
		{
			Place pl = c1.First();
			timer.Reset();
			timer.Start();
			c1.Contains(pl);
			timer.Stop();
			return $"Поиск первого: {timer.ElapsedTicks}\n";
		}
		public string Test2()
		{
			Place pl = c1.Last();
			timer.Reset();
			timer.Start();
			c1.Contains(pl);
			timer.Stop();
			return $"Поиск последнего: {timer.ElapsedTicks}\n";
		}
		public string Test3()
		{
			Place pl = c1.ElementAt(c1.Count / 2);
			timer.Reset();
			timer.Start();
			c1.Contains(pl);
			timer.Stop();
			return $"Поиск центрального: {timer.ElapsedTicks}\n";
		}
		public string Test4()
		{
			Place pl = new Place(0);
			timer.Reset();
			timer.Start();
			c1.Contains(pl);
			timer.Stop();
			return $"Поиск несуществуюшего: {timer.ElapsedTicks}\n";
		}
		public string Test5()
		{
			string str = c1.First().ToString();
			timer.Reset();
			timer.Start();
			c2.Contains(str);
			timer.Stop();
			return $"Поиск первого: {timer.ElapsedTicks}\n";
		}
		public string Test6()
		{
			string str = c1.Last().ToString();
			timer.Reset();
			timer.Start();
			c2.Contains(str);
			timer.Stop();
			return $"Поиск последнего: {timer.ElapsedTicks}\n";
		}
		public string Test7()
		{
			string str = c1.ElementAt(c1.Count / 2).ToString();
			timer.Reset();
			timer.Start();
			c2.Contains(str);
			timer.Stop();
			return $"Поиск центрального: {timer.ElapsedTicks}\n";
		}
		public string Test8()
		{
			string str = new Place(0).ToString();
			timer.Reset();
			timer.Start();
			c2.Contains(str);
			timer.Stop();
			return $"Поиск несуществуюшего: {timer.ElapsedTicks}\n";
		}
		public string Test9()
		{
			Place pl = c1.First();
			timer.Reset();
			timer.Start();
			c3.ContainsKey(pl);
			timer.Stop();
			return $"Поиск первого ключа: {timer.ElapsedTicks}\n";
		}
		public string Test10()
		{
			Place pl = c1.Last();
			timer.Reset();
			timer.Start();
			c3.ContainsKey(pl);
			timer.Stop();
			return $"Поиск последнего ключа: {timer.ElapsedTicks}\n";
		}
		public string Test11()
		{
			Place pl = c1.ElementAt(c1.Count / 2);
			timer.Reset();
			timer.Start();
			c3.ContainsKey(pl);
			timer.Stop();
			return $"Поиск центрального ключа: {timer.ElapsedTicks}\n";
		}
		public string Test12()
		{
			Place pl = new Place(0);
			timer.Reset();
			timer.Start();
			c3.ContainsKey(pl);
			timer.Stop();
			return $"Поиск несуществуюшего ключа: {timer.ElapsedTicks}\n";

		}
		public string Test13()
		{
			string str = c1.First().ToString();
			timer.Reset();
			timer.Start();
			c4.ContainsKey(str);
			timer.Stop();
			return $"Поиск первого ключа: {timer.ElapsedTicks}\n";
		}
		public string Test14()
		{
			string str = c1.Last().ToString();
			timer.Reset();
			timer.Start();
			c4.ContainsKey(str);
			timer.Stop();
			return $"Поиск последнего ключа: {timer.ElapsedTicks}\n";
		}
		public string Test15()
		{
			string str = c1.ElementAt(c1.Count / 2).ToString();
			timer.Reset();
			timer.Start();
			c4.ContainsKey(str);
			timer.Stop();
			return $"Поиск центрального ключа: {timer.ElapsedTicks}\n";
		}
		public string Test16()
		{
			string str = new Place(0).ToString();
			timer.Reset();
			timer.Start();
			c4.ContainsKey(str);
			timer.Stop();
			return $"Поиск несуществуюшего ключа: {timer.ElapsedTicks}\n";
		}
		public string Test17()
		{
			Region pl = c3.First().Value;
			timer.Reset();
			timer.Start();
			c3.ContainsValue(pl);
			timer.Stop();
			return $"Поиск первого значения: {timer.ElapsedTicks}\n";
		}
		public string Test18()
		{
			Region pl = c3.Last().Value;
			timer.Reset();
			timer.Start();
			c3.ContainsValue(pl);
			timer.Stop();
			return $"Поиск последнего значения: {timer.ElapsedTicks}\n";
		}
		public string Test19()
		{
			Region pl = c3.ElementAt(c1.Count / 2).Value;
			timer.Reset();
			timer.Start();
			c3.ContainsValue(pl);
			timer.Stop();
			return $"Поиск центрального значения: {timer.ElapsedTicks}\n";
		}
		public string Test20()
		{
			Region pl = new Region(0, 0, 0, "");
			timer.Reset();
			timer.Start();
			c3.ContainsValue(pl);
			timer.Stop();
			return $"Поиск несуществуюшего значения: {timer.ElapsedTicks}\n";
		}
	}
}
