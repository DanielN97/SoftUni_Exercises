namespace Problem01.FasterQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class FastQueue<T> : IAbstractQueue<T>
    {
        private Node<T> _head;
        private Node<T> tail;
        public int Count { get; private set; }

        public bool Contains(T item)
        {
            EnsureNotEmpty();

            Node<T> current = _head;

            while (current != null)
            {
                if (current.Item.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public T Dequeue()
        {
            EnsureNotEmpty();

            Node<T> oldHead = _head;
            Node<T> newHead = _head.Next;

            _head.Next = null;
            _head = newHead;

            Count--;

            return oldHead.Item;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>() { Item = item };

            if (Count == 0)
            {
                _head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public T Peek()
        {
            EnsureNotEmpty();

            return _head.Item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;

            while (current != null)
            {
                yield return current.Item;

                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void EnsureNotEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
        }
    }
}