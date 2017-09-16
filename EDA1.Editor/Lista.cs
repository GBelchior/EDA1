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

        // Construtor
        public ListaDupla()
        {
            list = null;
            count = 0;
        }

        // Se está vazia
        public bool Empty()
        {
            return (count==0);
        }

        // Insere um novo nó
        public void Insert(Node p, object x)
        {
            if (list == null) InsertEmpty(x);
            else if (p == list) InsertBeginning(x);
            else if (p == listEnd) InsertEnd(x);
            else InsertAfter(p, x);
        }

        private void InsertEmpty(object x)
        {
            Node n = new Node() { Info = x };
            list = n;
            listEnd = n;
        }

        private void InsertBeginning(object x)
        {
            Node n = new Node() { Info = x };
            Node y = list;

            n.Next = y;
            y.Prior = n;
            list = n;
        }

        private void InsertAfter(Node p, object x)
        {
            Node n = new Node() { Info = x };
            n.Prior = p;
            n.Next = p.Next;
            p.Next = n;

            if (p == listEnd) listEnd = n;
        }

        private void InsertEnd(object x)
        {
            Node n = new Node() { Info = x };
            n.Prior = listEnd;
            listEnd.Next = n;
            listEnd = n;
        }

        // Remove um nó
        public void Remove(Node p)
        {
            object x;
            Node q, r;
            if (p == null)
                throw new InvalidOperationException("Renovação vazia");
            x = p.Info;
            q = p.Prior;
            r = p.Next;
            q.Next = r;
            r.Prior = q;
            p = null;
        }
    }

}
