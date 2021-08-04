namespace Problem04.SinglyLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SinglyLinkedList<T> : IAbstractLinkedList<T>
    {
        private Node<T> _head;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            Node<T> newNode = new Node<T>() { Value = item };

            if (_head != null)
            {
                newNode.Next = _head;
            }

            _head = newNode;

            Count++;
        }

        public void AddLast(T item)
        {
            Node<T> newNode = new Node<T>() { Value = item };

            if (_head == null)
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

        public T GetFirst()
        {
            EnsureNotEmpty();

            return _head.Value;
        }

        public T GetLast()
        {
            EnsureNotEmpty();

            Node<T> currentNode = _head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Value;
        }

        public T RemoveFirst()
        {
            EnsureNotEmpty();

            Node<T> currentNode = _head;
            Node<T> newNode = _head.Next;

            _head.Next = null;
            _head = newNode;

            Count--;

            return currentNode.Value;
        }

        public T RemoveLast()
        {
            EnsureNotEmpty();

            Node<T> currentNode = _head;

            if (Count == 1)
            {
                _head = null;

                Count--;

                return currentNode.Value;
            }
            
            while (currentNode.Next.Next != null)
            {
                currentNode = currentNode.Next;
            }

            Node<T> lastNode = currentNode.Next;

            currentNode.Next = null;

            Count--;

            return lastNode.Value;
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