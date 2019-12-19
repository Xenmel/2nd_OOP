using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class MyCollection<T> : IEnumerable
    {
        protected class Node
        {
            public T data;
            public Node next = null;
            public Node prev = null;

            public Node(T data)
            {
                this.data = data;
            }
        }
        protected Node beg = null; // ссылка на первый элемент
        protected Node end = null; // ссылка на последний
        protected int count = 0; // количество элементов в list
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public MyCollection()
        { }

        public MyCollection(int size)
        {
            count = size;
        }

        MyCollection(MyCollection<T> c)
        {
            count = c.count;
            beg = c.beg;
            end = c.end;
        }

        public IEnumerator GetEnumerator()
        {
            Node pointer = beg;
            while (pointer != null)
            {
                yield return pointer.data;
                pointer = pointer.next;
            }

        }

        public void Add(T data)
        {
            Node new_node = new Node(data);
            if (beg == null)
            {
                beg = new Node(data);
                end = beg;
                count++;
                return;
            }
            beg.prev = new_node;
            new_node.next = beg;
            beg = new_node;
            count++;
        }

        public void Rm()
        {
            if (beg != null && beg.next != null)
            {
                beg.next.prev = null;
                beg = beg.next;
                
            }
            else if (beg != null && beg.next == null)
                beg = null;
        }

        public void Clear()
        {
            beg = null;
            end = beg;
            count = 0;
        }

        public bool Contains(T data)
        {
            foreach (T item in this)
            {
                if (item.Equals(data)) return true;
            }
            return false;
        }

    }
}
