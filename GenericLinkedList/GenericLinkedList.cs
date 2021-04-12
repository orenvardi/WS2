using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericLinkedList
{
    class GenericLinkedList<T> : IEnumerable<T>, IEnumerable
    {
        private Node head;

        public GenericLinkedList()
        { }

        public int Size { get; set; } = 0;

        public void Push(T data)
        {
            head = new Node(data, head);
            ++Size;
        }

        public T Pop() //from head
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Linked List is empty");
            }

            T dataToReturn = head.Data;
            head = head.Next;
            --Size;
            return dataToReturn;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Clear() 
        {
            head = null;
            Size = 0;
        }

        public T Head() 
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Linked List is empty");
            }
            return head.Data;
        }

        public int Count() 
        {
            return Size;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node node = head;
            while (node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        } 
        
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node node = head;
            while (node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        class Node
        {
            private T data;
            private Node next;

            public Node(T data, Node next)
            {
                Data = data;
                Next = next;
            }

            public T Data { get => data; set => data = value; }
            public Node Next { get => next; set => next = value; }
        }
    }
}
