using System;
using System.Collections.Generic;
using System.Text;

namespace WS2
{
    class TestObjectStack
    {
        public static void Main()
        {
            ObjectStack stack1 = new ObjectStack();
            ObjectStack stack2 = new ObjectStack(3);

            Console.WriteLine("stack1.IsEmpty(): " + stack1.IsEmpty());
            stack1.Clear();
            
            try {
                Console.WriteLine("stack1.Head(): " + stack1.Peek());
            } catch (InvalidOperationException e)
            {
                Console.WriteLine("InvalidOperationException");
            }
            Console.WriteLine("stack1.Count(): " + stack1.Count());

            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            Console.WriteLine("stack1.Count(): " + stack1.Count());
            Console.WriteLine("stack1.IsEmpty(): " + stack1.IsEmpty());
            Console.WriteLine("stack1.Head(): " + stack1.Peek());
            Console.WriteLine("stack1.Count(): " + stack1.Count());
            Console.WriteLine("stack1.IsEmpty(): " + stack1.IsEmpty());
            Console.WriteLine("stack1.Pop(): " + stack1.Pop());
            Console.WriteLine("stack1.Count(): " + stack1.Count());
            stack1.Clear();
            Console.WriteLine("stack1.Count(): " + stack1.Count());
            Console.WriteLine("stack1.IsEmpty(): " + stack1.IsEmpty());

            try {
                stack2.Peek();
            } catch (InvalidOperationException e) {
                Console.WriteLine("InvalidOperationException");
            }
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            try {
                stack2.Push(4);
            } catch (InvalidOperationException e) {
                Console.WriteLine("InvalidOperationException");
            }
            try
            {
                Console.WriteLine("stack2.Pop(): " + stack2.Pop());
                Console.WriteLine("stack2.Pop(): " + stack2.Pop());
                Console.WriteLine("stack2.Pop(): " + stack2.Pop());
                Console.WriteLine("stack2.Pop(): " + stack2.Pop());
            } catch (InvalidOperationException e)
            {
                Console.WriteLine("InvalidOperationException");
            }
        }
    }
}
