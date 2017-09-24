using System;

namespace Editor
{
    // Classe para o editor de texto
    public class Text
    {
        // Atributos e propriedades
        private ListaDupla listaTexto;
        
        // Retorna a primeira linha do texto
        public Node FirstLine
        {
            get { return listaTexto.FirstNode; }
        }

        // Número de linhas do texto
        public int NumLines
        {
            get { return listaTexto.Count; }
        }

        // Construtor
        public Text()
        {
            listaTexto = new ListaDupla();
        }

        // Nova linha: o valor -1 indica que o elemento deve ser 
        // inserido na primeira posição
        // Outros valores indicam a posição após a qual o novo elemento será
        // inserido, iniciando em 0
        public void InsertLine(string text, int position)
        {
            listaTexto.InsertAt(position, text);
        }

        // Iniciando em 0, a posição da linha que deve ser alterada
        public void ChangeLine(string text, int position)
        {
            listaTexto[position].Info = text;
        }

        // Excluindo uma linha - é passada a posição da linha començando em zero
        public void RemoveLine(int position)
        {
            listaTexto.RemoveAt(position);
        }

        public void DeleteLine(int position)
        {
            listaTexto.RemoveAt(position);
        }

    }

}
