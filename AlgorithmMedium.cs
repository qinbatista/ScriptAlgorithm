using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    class AlgorithmMedium
    {
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int temp = (a & b) << 1;
                a ^= b;
                b = temp;
            }
            return a;
        }

        public ListNode ReverseList(ListNode head)
        {
            if (head is null)
                return null;
            ListNode next = new ListNode();
            ListNode tail = new ListNode();
            while (head != null)
            {
                next = head.next;
                head.next = tail;
                tail = head;
                head = next;
            }
            return tail;
        }
    }
}
