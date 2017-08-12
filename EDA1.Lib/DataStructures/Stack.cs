using EDA1.Interfaces;
using System;

namespace EDA1.Lib.DataStructures
{
    /// <summary>
    /// FIFO Data Structure
    /// </summary>
    public class Stack : IStack
    {
        private object[] FStack;
        private int FIdxTop;
        private int FQtdMaxItems;

        /// <summary>
        /// Initializes a new stack data structure
        /// </summary>
        /// <param name="max">Maximum elements that the stack can hold</param>
        public Stack(int max)
        {
            FStack = new object[max];
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
        public void Push(object item)
        {
            if (IsFull()) throw new InvalidOperationException("The stack is full");
            FStack[FIdxTop++] = item;
        }

        /// <summary>
        /// Removes the top element of the stack
        /// </summary>
        /// <returns>The removed element</returns>
        public object Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("The stack has no items");
            return FStack[--FIdxTop];
        }

        /// <summary>
        /// Returns the top element of the stack without removing it
        /// </summary>
        /// <returns>The top element of the stack</returns>
        public object Top()
        {
            return FStack[FIdxTop-1];
        }
    }
}
