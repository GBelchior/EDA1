using System;

namespace EDA1.Lib.DataStructures
{
    /// <summary>
    /// FIFO Data Structure
    /// </summary>
    public class MyStack<T>
    {
        private T[] FStack;
        private int FIdxTop;
        private int FQtdMaxItems;

        /// <summary>
        /// Initializes a new stack data structure
        /// </summary>
        /// <param name="max">Maximum elements that the stack can hold</param>
        public MyStack(int max)
        {
            FStack = new T[max];
            FQtdMaxItems = max;
            FIdxTop = 0;
        }

        /// <summary>
        /// Returns if the stack is full
        /// </summary>
        /// <returns><see cref="true"/> if the stack is full, else <see cref="false"/></returns>
        public bool IsFull()
        {
            return FIdxTop >= FQtdMaxItems;
        }

        /// <summary>
        /// Returns if the stack is empty
        /// </summary>
        /// <returns><see cref="true"/> if the stack is empty, else <see cref="false"/></returns>
        public bool IsEmpty()
        {
            return FIdxTop == 0;
        }

        /// <summary>
        /// Inserts an element at the top of the stack
        /// </summary>
        /// <param name="item">The element to be inserted</param>
        public void Push(T item)
        {
            if (IsFull()) throw new StackOverflowException("The stack is full");
            FStack[FIdxTop++] = item;
        }

        /// <summary>
        /// Removes the top element of the stack
        /// </summary>
        /// <returns>The removed element</returns>
        public T Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("The stack has no items");
            return FStack[--FIdxTop];
        }

        /// <summary>
        /// Returns the top element of the stack without removing it
        /// </summary>
        /// <returns>The top element of the stack</returns>
        public T Top()
        {
            return FStack[FIdxTop-1];
        }

        public static implicit operator MyStack<T>(MyStack<char> v)
        {
            throw new NotImplementedException();
        }
    }
}
