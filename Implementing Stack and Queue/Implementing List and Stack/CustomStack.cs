using System;
using System.Collections.Generic;
using System.Text;

namespace Implementing_List_and_Stack
{
    class CustomStack
    {
        private const int InitialCapacity = 4;

        private int[] items;
        private int count;

        public CustomStack()
        {
            count = 0;
            items = new int[InitialCapacity];
        }

        public int Count { get; set; }

        public void Push(int element)
        {
            if (Count == items.Length)
            {
                int[] copy = new int[items.Length * 2];
                Array.Copy(items, copy, items.Length);
                items = copy;
            }

            items[Count] = element;
            count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int itemToPop = items[Count - 1];
            items[Count - 1] = default;

            Count--;

            if (Count == items.Length / 4)
            {
                int[] copy = new int[items.Length / 2];
                Array.Copy(items, copy, items.Length);
                items = copy;
            }

            return itemToPop;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            return items[Count - 1];
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }
    }
}
