using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<Т>
    {
        private ListNode<Т> head;
        private ListNode<Т> tail;

        public int Count { get; private set; }

        public void AddFirst(Т element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode<Т>(element);
            }
            else
            {
                ListNode<Т> newHead = new ListNode<Т>(element);
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(Т element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode<Т>(element);
            }
            else
            {
                ListNode<Т> newTail = new ListNode<Т>(element);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public Т RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            Т firstElement = head.Value;
            head = head.NextNode;

            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.PreviousNode = null;
            }

            Count--;

            return firstElement;
        }

        public Т RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            Т lastElement = tail.Value;
            tail = tail.PreviousNode;

            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.NextNode = null;
            }

            Count--;

            return lastElement;
        }

        public void ForEach(Action<Т> action)
        {
            ListNode<Т> currentNode = head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public Т[] ToArray()
        {
            Т[] array = new Т[Count];

            int index = 0;

            ListNode<Т> currentNode = head;

            while (currentNode != null)
            {
                array[index] = currentNode.Value;
                currentNode = currentNode.NextNode;

                index++;
            }

            return array;
        }
    }
}
