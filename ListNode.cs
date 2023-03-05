using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public void AddNode(int val)
        {
            ListNode newNode = new ListNode();
            newNode.val = val;

            ListNode currentNode = this;
            while (true)
            {
                if (currentNode.next == null)
                {
                    currentNode.next = newNode;
                    break;
                }
                else
                    currentNode = currentNode.next;
            }
        }
    }
}
