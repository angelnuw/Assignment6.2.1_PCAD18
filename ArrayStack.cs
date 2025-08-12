using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._2._1
{
    class ArrayStack
    {
        private int[] items;
        private int top;
        private const int DefaultCapacity = 10;

        public ArrayStack(int capacity = DefaultCapacity)
        {
            if (capacity < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than 0.");
            }
            items = new int[capacity];
            top = -1;
        }
        //hecper checks (quick yes/nof stack is empty)
        public bool IsEmpty()
        {
            return top == -1;
        }
        //hecper checks (quick yes/no stack is full)
        public bool IsFull()
        {
            return top == items.Length - 1;
        }
        //push an item onto the stack
        public void Push(int item)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Stack is full.");
            }
            items[++top] = item;
        }
        //pop an item off the stack
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return items[top--];
        }
        //time space complexity of O(1)
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return items[top];
        }

        public void Clear()
        {
            top = -1; // Reset the stack by setting top to -1
        }

    }
}
