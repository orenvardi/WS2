using System;
using System.Collections.Generic;
using System.Text;

namespace GenericLinkedList
{
    class TestGenericLinkedList
    {
        static void Main(string[] args)
        {
            GenericLinkedList<int> listInt = new GenericLinkedList<int>();

            Console.WriteLine("listInt.IsEmpty(): " + listInt.IsEmpty());
            listInt.Clear();

            try
            {
                Console.WriteLine("listInt.Head(): " + listInt.Head());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("InvalidOperationException");
            }
            Console.WriteLine("listInt.Count(): " + listInt.Count());

            listInt.Push(1);
            listInt.Push(2);
            listInt.Push(3);
            listInt.Push(4);
            Console.WriteLine("listInt.Count(): " + listInt.Count());
            Console.WriteLine("listInt.IsEmpty(): " + listInt.IsEmpty());
            Console.WriteLine("listInt.Head(): " + listInt.Head());
            Console.WriteLine("listInt.Count(): " + listInt.Count());
            Console.WriteLine("listInt.IsEmpty(): " + listInt.IsEmpty());
            Console.WriteLine("listInt.Pop(): " + listInt.Pop());
            Console.WriteLine("listInt.Count(): " + listInt.Count());
            foreach (var node in listInt)
            {
                Console.WriteLine("hi "+ listInt.Pop());
            }
            listInt.Clear();
            Console.WriteLine("listInt.Count(): " + listInt.Count());
            Console.WriteLine("listInt.IsEmpty(): " + listInt.IsEmpty());

            //try
            //{
            //    stack2.Peek();
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("InvalidOperationException");
            //}
            //stack2.Push(1);
            //stack2.Push(2);
            //stack2.Push(3);
            //try
            //{
            //    stack2.Push(4);
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("InvalidOperationException");
            //}
            //try
            //{
            //    Console.WriteLine("stack2.Pop(): " + stack2.Pop());
            //    Console.WriteLine("stack2.Pop(): " + stack2.Pop());
            //    Console.WriteLine("stack2.Pop(): " + stack2.Pop());
            //    Console.WriteLine("stack2.Pop(): " + stack2.Pop());
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("InvalidOperationException");
            //}
        }
    }
}
