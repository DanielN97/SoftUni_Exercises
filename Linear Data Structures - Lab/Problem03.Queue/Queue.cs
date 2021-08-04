namespace Problem03.Queue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Queue<T> : IAbstractQueue<T>
    {
        private Node<T> _head;

        public int Count { get; private set; }

        public bool Contains(T item)
        {
            Node<T> currentNode = _head;

            while (currentNode != null)
            {
                if (currentNode.Value.ToString() == item.ToString())
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public T Dequeue()
        {
            EnsureNotEmpty();

            var oldHead = _head.Value;
            var newHead = _head.Next;

            _head.Next = null;
            _head = newHead;

            Count--;

            return oldHead;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T> { Value = item };

            if (Count == 0)
            {
                _head = newNode;
            }
            else
            {
                Node<T> currentNode = _head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }

            Count++;
        }

        public T Peek()
        {
            EnsureNotEmpty();

            return _head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> currentNode = _head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        private void EnsureNotEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
        }
    }
}