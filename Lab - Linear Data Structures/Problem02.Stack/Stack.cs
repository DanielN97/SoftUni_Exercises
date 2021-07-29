﻿namespace Problem02.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IAbstractStack<T>
    {
        private Node<T> _top;

        public int Count { get; private set; }

        public bool Contains(T item)
        {
            Node<T> currentNode = _top;

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

        public T Peek()
        {
            EnsureNotEmpty();

            return _top.Value;
        }

        public T Pop()
        {
            EnsureNotEmpty();

            var currentTop = _top.Value;
            var newTop = _top.Next;

            _top.Next = null;
            _top = newTop;

            Count--;

            return currentTop;
        }

        public void Push(T item)
        {
            var newNode = new Node<T>
            {
                Value = item,
                Next = _top
            };

            _top = newNode;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = _top;

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
            if (Count <= 0)
            {
                throw new InvalidOperationException("No elements");
            }
        }
    }
}