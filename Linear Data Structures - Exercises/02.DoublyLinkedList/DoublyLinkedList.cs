namespace Problem02.DoublyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class DoublyLinkedList<T> : IAbstractLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            Node<T> newHead = new Node<T>() { Item = item };

            if (Count == 0)
            {
                head = tail = newHead;
            }
            else
            {
                head.Previous = newHead;
                newHead.Next = head;
                head = newHead;
                head.Previous = null;
            }

            Count++;
        }

        public void AddLast(T item)
        {
            Node<T> newTail = new Node<T>() { Item = item };

            if (Count == 0)
            {
                head = tail = newTail;
            }
            else
            {
                tail.Next = newTail;
                newTail.Previous = tail;
                tail = newTail;
                tail.Next = null;
            }

            Count++;
        }

        public T GetFirst()
        {
            EnsureNotEmpty();

            return head.Item;
        }

        public T GetLast()
        {
            EnsureNotEmpty();

            return tail.Item;
        }

        public T RemoveFirst()
        {
            EnsureNotEmpty();

            Node<T> oldHead = head;

            if (Count == 1)
            {
                head = tail = null;
            }
            else
            {
                Node<T> newHead = head.Next;

                head.Next = null;
                head = newHead;
            }

            Count--;

            return oldHead.Item;
        }

        public T RemoveLast()
        {
            EnsureNotEmpty();

            Node<T> oldTail = tail;

            if (Count == 1)
            {
                head = tail = null;
            }
            else
            {
                Node<T> newTail = tail.Previous;

                tail.Previous = null;
                tail = newTail;
            }

            Count--;

            return oldTail.Item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;

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