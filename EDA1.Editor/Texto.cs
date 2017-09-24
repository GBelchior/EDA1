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

        // N�mero de linhas do texto
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
        // inserido na primeira posi��o
        // Outros valores indicam a posi��o ap�s a qual o novo elemento ser�
        // inserido, iniciando em 0
        public void InsertLine(string text, int position)
        {
            listaTexto.InsertAt(position, text);
        }

        // Iniciando em 0, a posi��o da linha que deve ser alterada
        public void ChangeLine(string text, int position)
        {
            listaTexto[position].Info = text;
        }

        // Excluindo uma linha - � passada a posi��o da linha comen�ando em zero
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