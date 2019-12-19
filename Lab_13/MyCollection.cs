using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    delegate void CollectionEventHandler(object sender, CollectionHandlerEventArgs args);

    class Collection : MyCollection<Place>
    {
        string Name { get; set; } = "Collection";

        public event CollectionEventHandler CollectionCountChange;
        public event CollectionEventHandler CollectionReferenceChange;

        private void CollectionCountChanged (object sender, CollectionHandlerEventArgs args)
        {
            if (CollectionCountChange != null)
                 CollectionCountChange(this, args);
        }

        private void CollectionReferenceChanged(object sender, CollectionHandlerEventArgs args)
        {
            if (CollectionReferenceChange != null)
                CollectionReferenceChange(this, args);
        }

        public void Remove(int j)
        {
            Node p = beg;
            if (j == 0)
            {
                CollectionCountChanged(this, new CollectionHandlerEventArgs(Name, p.data, "удален элемент"));
                beg.next.prev = null;
                beg = beg.next;
                return;
            }
            for (int i = 0; p != null; p = p.next, i++)
                if (i + 1 == j)
                    break;
            if (p.next == end)
            {
                CollectionCountChanged(this, new CollectionHandlerEventArgs(Name, p.next.data, "удален элемент"));
                end = p;
                p.next = null;
                return;
            }
            else if (p.next != null)
            {
                CollectionCountChanged(this, new CollectionHandlerEventArgs(Name, p.next.data, "удален элемент"));
                p.next = p.next.next;
                if(p.next.next != null)
                    p.next.next.prev = p;
            }
            else Console.WriteLine("Такого элемента неть.");
            
        }

        public override void Add(Place data)
        {
            base.Add(data);
            CollectionCountChanged(this, new CollectionHandlerEventArgs(Name, data, "добавлен элемент"));
        }

        public Node this[int i]
        {           
            get
            {
                Node p = beg;
                for (int j = 0; p != null; p = p.next, j++)
                    if (i == j)
                        return p;
                return null;
            }
            set
            {
                Node p = beg;
                for (int j = 0; p != null; p = p.next, j++)
                    if (i == j)
                        break;
                p = value;
                CollectionReferenceChanged(this, new CollectionHandlerEventArgs(Name, p.data, "изменен элемент"));
            }
        }
    }

    class CollectionHandlerEventArgs : System.EventArgs
    {
        public string ColName { get; private set; }
        public Place ChangedItem { get; private set; }
        public string EventDesc { get; private set; }

        public override string ToString()
        {
            return $"В коллекции {ColName} {EventDesc}: {ChangedItem}";
        }
        public CollectionHandlerEventArgs(string colname, Place item, string desc) 
        {
            ColName = colname;
            ChangedItem = item;
            EventDesc = desc;
        }
    }

    class Journal : IEnumerable
    {
        List<JournalEntry> journal = new List<JournalEntry>();

        public void SubOnColChanged(Collection col)
        {
            col.CollectionCountChange += AddEntry;
        }

        public IEnumerator GetEnumerator()
        {
           return journal.GetEnumerator();
        }

        public void SubOnRefChanged(Collection col)
        {
            col.CollectionReferenceChange += AddEntry;
        }
            
        private void AddEntry(object sender, CollectionHandlerEventArgs args)
        {
            journal.Add(new JournalEntry(args));       
        }
    }

    class JournalEntry
    {
        public string ColName { get; set; }
        public string EventDesc { get; set; }
        public string ChangedItem { get; set; }

        public JournalEntry(CollectionHandlerEventArgs arg)
        {
            ColName = arg.ColName;
            EventDesc = arg.EventDesc;
            ChangedItem = arg.ChangedItem.ToString();
        }

        public override string ToString()
        {
            return $"В коллекции {ColName} {EventDesc}: {ChangedItem}";
        }
    }


}
