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
        // Outros valores indicam a posição após a qual o novo elmento será
        // inserido, ininciando em 0
        public void InsertLine(string text, int position)
        {
        }

        // Iniciando em 0, a posição da linha que deve ser alterada
        public void ChangeLine(string text, int position)
        {
        }

        // Excluindo uma linha - é passada a posição da linha començando em zero
        public void RemoveLine(int position)
        {
        }

        public void DeleteLine(int position)
        {
            // Implementar!
        }

    }

}
