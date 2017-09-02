using System;

namespace Paint
{

    public class Fila
    {
        private int size, front, rear, count;
        private object[] elements;

        public Fila(int size)
        {
            this.size = size;
            front = rear = count = 0;
            elements = new object[size];
        }

        public bool Empty()
        {
            return count == 0;
        }

        public bool Full()
        {
            return count == size - 1;
        }

        public void Insert(object x)
        {
            if (Full()) throw new StackOverflowException("Fila Cheia");
            //rear = (rear == size - 1) ? 0 : rear + 1;
            if (rear == size - 1) rear = 0;
            else rear++;

            elements[rear] = x;
            count++;
        }

        public object Remove()
        {
            if (Empty()) throw new InvalidOperationException("Fila Vazia");
            //front = (front == size - 1) ? 0 : front + 1;
            if (front == size - 1) front = 0;
            else front++;

            count--;
            return elements[front];
        }
    }
}
