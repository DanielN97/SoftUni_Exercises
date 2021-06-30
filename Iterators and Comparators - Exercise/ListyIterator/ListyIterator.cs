using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(params T[] items)
        {
            this.items = items.ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        public bool HasNext()
        {
            return index < items.Count - 1;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;

                return true;
            }

            return false;
        }

        public void Print()
        {
            if (index >= items.Count)
            {
                throw new IndexOutOfRangeException("Invalid Operation!");
            }

            Console.WriteLine(items[index]);
        }

        public void PrintAll()
        {
            Console.WriteLine(String.Join(" ", items));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
