using System;

namespace Editor
{
    /// <summary>
    /// Lista duplamente ligada linear
    /// </summary>
    public class ListaDupla
    {
        private Node list;
        private Node listEnd;
        private int count;

        public Node FirstNode
        {
            get { return list; }
        }
        public int Count
        {
            get { return count; }
        }

        public Node this[int index]
        {
            get
            {
                if (index > count) throw new OverflowException("Invalid index");

                Node n = list;
                int curPos = 0;

                while (n.Next != null && curPos++ != index)
                {
                    n = n.Next;
                }

                return n;
            }
        }

        // Construtor
        public ListaDupla()
        {
            list = null;
            count = 0;
        }

        // Se está vazia
        public bool Empty()
        {
            return (count == 0);
        }

        // Insere um novo nó
        public void Insert(Node p, object x)
        {
            if (list == null) InsertEmpty(x);
            else if (p == list) InsertBeginning(x);
            else if (p == listEnd) InsertEnd(x);
            else InsertAfter(p, x);

            count++;
        }

        private void InsertEmpty(object x)
        {
            Node n = new Node() { Info = x };
            list = n;
            listEnd = n;

            count++;
        }

        public void InsertBeginning(object x)
        {
            Node n = new Node() { Info = x };
            Node y = list;

            n.Next = y;
            y.Prior = n;
            list = n;

            count++;
        }

        public void InsertAt(int position, object x)
        {
            if (position == -1)
            {
                InsertEmpty(x);
                return;
            }

            InsertAfter(this[position], x);
        }

        public void InsertAfter(Node p, object x)
        {
            Node n = new Node() { Info = x };
            n.Prior = p;
            n.Next = p.Next;
            p.Next = n;

            if (p == listEnd) listEnd = n;

            count++;
        }

        public void InsertEnd(object x)
        {
            Node n = new Node() { Info = x };
            n.Prior = listEnd;
            listEnd.Next = n;
            listEnd = n;

            count++;
        }

        // Remove um nó
        public void RemoveAt(int position)
        {
            Remove(this[position]);
        }

        public void Remove(Node p)
        {
            if (p == null) throw new InvalidOperationException("Renovação vazia");
            if (p.Prior != null) p.Prior.Next = p.Next;
            if (p.Next != null) p.Next.Prior = p.Prior;

            count--;
        }
    }

}
