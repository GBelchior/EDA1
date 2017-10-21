using System;

namespace ExercArvore
{
    // Classe com o nó
    public class Node
    {
        private int info;
        private Node esq, dir, pai;

        // Construtor
        public Node(int x, Node p)
        {
            info = x;
            pai = p;
            esq = null;
            dir = null;
        }

        // Properties
        public int Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }
        public Node Esq
        {
            get
            {
                return esq;
            }
            set
            {
                esq = value;
            }
        }
        public Node Dir
        {
            get
            {
                return dir;
            }
            set
            {
                dir = value;
            }
        }
        public Node Pai
        {
            get
            {
                return pai;
            }
            set
            {
                pai = value;
            }
        }
    }

    // Classe com a árvore
    public class BTree
    {
        // Nó raiz
        private Node raiz;
        public Node Raiz
        {
            get
            {
                return raiz;
            }
            set
            {
                raiz = value;
            }
        }

        // Construtor
        public BTree()
        {
            raiz = null;
        }

        // Inserindo na árvore
        public void Insert(int x)
        {
            if (raiz == null) raiz = new Node(x, null);
            else Insert(x, raiz);
        }

        // Pesquisa na árvore
        public Node Find(int x)
        {
            return Find(x, raiz);
        }

        // Função para excluir nó
        public void Remove(int x)
        {
            Remove(x, raiz);
        }

        private void Insert(int x, Node n)
        {
            if (x < n.Info)
            {
                if (n.Esq == null) n.Esq = new Node(x, n);
                else Insert(x, n.Esq);
            }
            else
            {
                if (n.Dir == null) n.Dir = new Node(x, n);
                else Insert(x, n.Dir);
            }
        }

        private Node Find(int x, Node n)
        {
            if (n == null || n.Info == x) return n;
            if (x < n.Info) return Find(x, n.Esq);
            return Find(x, n.Dir);
        }

        private Node KillMax(Node n)
        {
            if (n.Dir == null)
            {
                Node t = n;
                if (n.Pai.Dir == n) n.Pai.Dir = n.Esq;
                else n.Pai.Esq = n.Esq;

                if (n.Esq != null) n.Esq.Pai = n.Pai;
                return t;
            }
            return KillMax(n.Dir);
        }

        private void Remove(int x, Node n)
        {
            Node f = Find(x, n);
            if (f == null) return;
            if (f.Esq == null)
            {
                if (f.Pai == null)
                {
                    raiz = f.Dir;
                }
                else
                {
                    if (f.Pai.Dir == f)
                    {
                        f.Pai.Dir = f.Dir;
                    }
                    else
                    {
                        f.Pai.Esq = f.Dir;
                    }

                    if (f.Dir != null) f.Dir.Pai = f.Pai;
                }
            }
            else
            {
                if (f.Dir == null)
                {
                    if (f.Pai == null)
                        raiz = f.Esq;
                    else
                    {
                        if (f.Pai.Dir == f)
                            f.Pai.Dir = f.Esq;
                        else
                            f.Pai.Esq = f.Esq;
                        if (f.Esq != null) f.Esq.Pai = f.Pai;
                    }
                }
                else
                {
                    Node p = KillMax(f.Esq);
                    f.Info = p.Info;
                }

                if (raiz != null) raiz.Pai = null;
            }
        }
    }
}
