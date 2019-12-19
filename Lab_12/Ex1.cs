using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class UList : IEnumerable
	{
		protected class Node
		{
			public object data = null;
			public Node next = null;

			public Node(object data)
			{
				this.data = data;
			}
		}

		private Node beg = null; // ссылка на первый элемент
		private Node end = null; // ссылка на последний

		private int count = 0; // количество элементов в list

		public int Count
		{
			get { return count; }
			private set { count = value; }
		}


		public UList()
		{}

		public IEnumerator GetEnumerator() 
		{
			Node pointer = beg;
			while (pointer != null)
			{
				yield return pointer.data;
				pointer = pointer.next;
			}

		}

		public void Add(object data)
		{
			Node new_node = new Node(data);
			if (beg == null)
			{
				beg = new Node(data);
				end = beg;
				count++;
				return;
			}
			end.next = new_node;
			end = end.next;
			count++;
		}

		public bool Remove(object data)
		{
			if (data == null) return false;

			Node p = beg;
			while (p.next != null)
			{
				if(data.Equals(beg.data))
				{
					beg = beg.next;
					return true;
				}
				if (data.Equals(p.next.data))
				{
					p = p.next.next;
					count--;
					return true;
				}
				p = p.next;
			}
			return false;
		}

		public void Clear()
		{
			beg = null;
			end = beg;
			count = 0;
		}

		public bool Contains(object data)
		{
			foreach (object item in this)
			{
				if (item.Equals(data)) return true;
			}
			return false;
		}

		public void Insert(object data, int i) // Задание 1
		{
			Node new_node = new Node(data);
			Node p = beg;
			if (i == 0)
			{
				new_node.next = beg;
				beg = new_node;
			}

			for(int j = 0; p != null; p = p.next)
			{
				if (j + 1 == i)
					break;
			}

			if (p != null && p.next != end)
			{
				Node tmp = p.next;
				p.next = new_node;
				new_node.next = tmp;
			}
			else if (p.next == end)
			{
				p.next = new_node;
				new_node = null;
				end = new_node;
			}
			else Console.WriteLine("Такого элемента в массиве нет.");
		}
	}

	class UDList : IEnumerable
	{
		protected class Node
		{
			public object data = null;
			public Node next = null;
			public Node prev = null;

			public Node(object data)
			{
				this.data = data;
			}
		}
		protected class DListEnumerator : IEnumerator
		{
			bool began = false;
			Node cur, beg;
			public DListEnumerator(Node begin)
			{
				beg = begin;
				cur = begin;
			}
			object IEnumerator.Current => cur.data;

			bool IEnumerator.MoveNext()
			{
				if (began) cur = cur.next;
				else began = true;
				return (cur != null);
			}

			void IEnumerator.Reset()
			{
				began = false;
				cur = beg;
			}
		}

		private Node beg = null;
		private Node end = null;

		private int count = 0;

		public int Count
		{
			get { return count; }
			private set { count = value; }
		}

		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)new DListEnumerator(beg);
		}

		public void Add(object data)
		{
			Node new_node = new Node(data);
			if (beg == null)
			{
				beg = new Node(data);
				end = beg;
				count++;
				return;
			}
			end.next = new_node;
			new_node.prev = end;
			end = end.next;
			count++;
		}

		public bool Remove(object data)
		{
			if (data == null) return false;

			Node p = beg;
			while (p != null)
			{
				if (data.Equals(p.data))
				{
					if (p == beg)
					{
						if (beg.next != null)
						{
							beg = beg.next;
							beg.prev = null;
						}
						else
						{
							beg = null;
						}
					}
					else if (p == end)
					{
						if (end.prev != null)
						{
							end = end.prev;
							end.next = null;
						}
						else
						{
							end = null;
						}

					}
					else
					{
						p.prev.next = p.next;
						p.next.prev = p.prev;
						p = null;
					}
					count--;
					return true;
				}
				p = p.next;
			}
			return false;
		}

		public void Clear()
		{
			beg = null;
			end = beg;
			count = 0;
		}

		public bool Contains(object data)
		{
			foreach (object item in this)
			{
				if (item.Equals(data)) return true;
			}
			return false;
		}
		
		public void RemoveOdd() //Задание 2
		{
			Node p = beg;
			for(int i = 0; p != null; p = p.next, i++)
			{
				if(i == 0)
				{
					beg = p.next;
					continue;
				}

				if(i % 2 == 0 && p != end)
				{
					p.prev.next = p.next;
					p.next.prev = p.prev;
				}
				else if(i % 2 == 0 && p == end)
				{
					p.prev.next = null;
					end = p.prev; ;
				}
			}
		}
	}

	enum Direction
	{
		Left, Right
	}

	class USTree
	{
		int level;
		USTree left = null;
		USTree right = null;
		USTree parent = null;
		int data = 0;


		public USTree(Func<object> constructor)
		{
		}
		public USTree(int obj, USTree parent)
		{
			data = obj;
			this.parent = parent;
			if (parent == null) level = 0;
			else level = parent.level + 1;
		}

		public void Add(int obj) // идеально сбалансированное дерево
		{
			IComparable obj1 = data as IComparable; 
			IComparable obj2 = obj as IComparable;

			if (obj1.CompareTo(obj2) < 1)
			{
				if (right == null)
					right = new USTree(obj, this);
				else
				{
					right.Add(obj);
				}
			}
			else
			{
				if (left == null)
					left = new USTree(obj, this);
				else left.Add(obj);
			}
		}

		public void Print(int l)
		{
			if (left != null) left.Print(l + 3);

			Console.Write(new string(' ', l));
			Console.WriteLine(data);

			if (right != null) right.Print(l + 3);
		}


		static int res = 0;
		static int count = 0;

		static public double Average(USTree p)
		{ 
			Run(p);
			return (double)res / count;
		}

		static void Run(USTree p)
		{
			if (p != null)
			{
				res += (int)p.data;
				count++;
				Run(p.left);
				Run(p.right);//переход к правому поддереву
	
			}

		}
	}
}

