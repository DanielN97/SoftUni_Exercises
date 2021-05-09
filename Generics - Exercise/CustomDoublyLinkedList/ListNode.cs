using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class ListNode<Т>
    {
        public Т Value { get; set; }
        public ListNode<Т> NextNode { get; set; }
        public ListNode<Т> PreviousNode { get; set; }

        public ListNode(Т value)
        {
            Value = value;
        }
    }
}
