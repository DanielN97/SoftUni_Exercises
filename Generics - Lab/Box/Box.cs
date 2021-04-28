using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            list.Add(item);

            Count++;
        }

        public T Remove()
        {
            T itemToRemove = default;

            if (Count > 0)
            {
                itemToRemove = list[Count - 1];

                list.Remove(itemToRemove);

                Count--;
            }

            return itemToRemove;
        }
    }
}
