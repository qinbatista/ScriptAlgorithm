using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class Container
    {
        private class Node
        {
            public Node Next;
            public Node Prev;
            public bool Value;

            public Node(Node prev)
            {
                var randomGen = new Random(DateTime.Now.Millisecond);
                Value = randomGen.Next(2) < 1;
                Prev = prev;
            }
        }

        private Node current;

        public Container(int count = 0)
        {
            if (count < 1)
            {
                var randomGen = new Random(DateTime.Now.Millisecond);
                count = randomGen.Next(1, 3); //Could be up to Int32.MaxValue, reduced for sake of test memory
            }
            Node prev = null;
            for (int i = 0; i < count; i++)
            {
                var currentNode = new Node(prev);//give prev node when initialize
                if (prev != null)
                {
                    prev.Next = currentNode; //prev node connects current node to build double linked list
                }
                if (current == null)
                {
                    current = currentNode;//initial the head node, only executed once
                }
                prev = currentNode;
            }
            prev.Next = current;
            current.Prev = prev;
        }

        public bool Value
        {
            get { return current.Value; }
            set { current.Value = value; }
        }

        public void MoveForward()
        {
            current = current.Next;
        }

        public void MoveBackward()
        {
            current = current.Prev;
        }
    }
}
