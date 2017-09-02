using System;
using System.Collections;
using System.Text;
using System.Drawing;

namespace Paint
{
    public class Pintor
    {

        #region Implementar

        // Função que pinta a imagem
        public int Colorir(int x, int y, Color C1, Bitmap b)
        {
            /* Dicas: 
             *  - Pode-se colocar na fila x e y. ou pode-se colocar direto um ponto. Pode-se usar a classe Point para isso. Ex,: Point p = new Point(x,y)
             *  - Uma variável que armazena cor é do tipo Color. Ex.: Color cor_ponto
             *  - Para pegar uma cor de um ponto do Bitmap use: b.GetPixel(x,y)
             *  - Para gravar uma cor em um ponto do Bitmap use: b.SetPixel(x,y,cor)
             * - Uma cor é igual a outra se seus 3 canais (R, G e B) forem iguais
             * */

            Fila f = new Fila(b.Size.Width * b.Size.Height);
            Color LOriginalColor = b.GetPixel(x, y);
            int LNumPixels = 0;

            if (LOriginalColor == C1) return 0;

            f.Insert(new Point(x, y));

            while (!f.Empty())
            {
                Point p = (Point)f.Remove();
                if (p.X - 1 >= 0 && b.GetPixel(p.X - 1, p.Y) == LOriginalColor)
                {
                    b.SetPixel(p.X - 1, p.Y, C1);
                    f.Insert(new Point(p.X - 1, p.Y));
                }

                if (p.X + 1 < b.Size.Width && b.GetPixel(p.X + 1, p.Y) == LOriginalColor)
                {
                    b.SetPixel(p.X + 1, p.Y, C1);
                    f.Insert(new Point(p.X + 1, p.Y));
                }

                if (p.Y - 1 >= 0 && b.GetPixel(p.X, p.Y - 1) == LOriginalColor)
                {
                    b.SetPixel(p.X, p.Y - 1, C1);
                    f.Insert(new Point(p.X, p.Y - 1));
                }

                if (p.Y + 1 < b.Size.Height && b.GetPixel(p.X, p.Y + 1) == LOriginalColor)
                {
                    b.SetPixel(p.X, p.Y + 1, C1);
                    f.Insert(new Point(p.X, p.Y + 1));
                }

                b.SetPixel(p.X, p.Y, C1);
                LNumPixels++;
            }

            return LNumPixels;
        }

        #endregion
    }
}
