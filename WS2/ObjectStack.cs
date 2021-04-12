using System;

namespace WS2
{
    class ObjectStack
    {
        private int size = 0;
        private int capacity;
        private static int DEFAULT_CAPACITY = 10;
        private Object[] stack;

        public ObjectStack() : this(DEFAULT_CAPACITY) {}

        public ObjectStack(int capacity)
        {
            this.capacity = capacity;
            stack = new object[capacity];
        }

        public int Size { get => size; set => size = value; }

        public void Push(Object obj) 
        {
            if (Size == capacity) // --> realloc in reality
            {
                throw new InvalidOperationException("Stack is full");
            }

            stack[Size] = obj;
            ++Size;
        }
        public Object Pop() 
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            --Size;
            Object obj = stack[Size];
            stack[Size] = null;
            return obj;
        }
        public bool IsEmpty() 
        {
            return Size == 0;
        }
        public void Clear() 
        { 
            for (int i = 0; i < Size; ++i)
            {
                stack[i] = null;
            }
            Size = 0; 
        }
        public Object Peek() 
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return stack[Size - 1];
        }
        public int Count() 
        {
            return Size;
        }
    }
}
