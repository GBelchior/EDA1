using EDA1.Lib.Extensions;
using EDA1.Lib.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Calculadora
{
    /// <summary>
    /// Classe da calculadora
    /// </summary>
    public class Calc
    {

        /// <summary>
        /// Construtor
        /// </summary>
        public Calc()
        {
        }

        public bool IsOperator(char candidate)
        {
            switch (candidate)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '^': return true;
                default: return false;
            }
        }

        public bool IsOperand(char candidate)
        {
            if (candidate >= 'A' && candidate <= 'Z' ||
                candidate >= 'a' && candidate <= 'z')
            {
                return true;
            }

            return false;
        }

        public int Priority(char oper)
        {
            switch (oper)
            {
                case '(':
                case '{':
                case '[':
                    return 1;
                case '+':
                case '-':
                    return 2;
                case '*':
                case '/':
                    return 3;
                case '^':
                    return 4;
                default:
                    throw new ArgumentException(oper + " is an invalid argument.");
            }
        }

        /// <summary>
        /// Analisa a express�o e retorna verdadeiro ou falso se est� ou n�o correta
        /// </summary>
        /// <param name="AExpr">Express�o infixa a analisar</param>
        /// <returns>Se � v�lida ou n�o</returns>
        public bool Analisar(string AExpr)
        {
            MyStack<char> LStack = new MyStack<char>(AExpr.Length);

            Dictionary<char, char> LOpenCloseCharacters = new Dictionary<char, char>();
            LOpenCloseCharacters.Add('(', ')');
            LOpenCloseCharacters.Add('[', ']');
            LOpenCloseCharacters.Add('{', '}');


            foreach (char LChar in AExpr)
            {
                // Se o LChar for uma abertura de par�ntesis
                if (LOpenCloseCharacters.ContainsKey(LChar))
                {
                    // Coloca ele na pilha
                    LStack.Push(LChar);
                }

                // Se o LChar for um fechamento de par�ntesis
                if (LOpenCloseCharacters.ContainsValue(LChar))
                {
                    // Se a pilha est� vazia, estou tentando fechar um par�ntesis sem abrir
                    if (LStack.IsEmpty()) return false;

                    // Pego o caracter anterior e checo se ele bate com a abertura de par�ntesis / colchetes / chaves
                    char LBeforeChar = LStack.Pop();

                    // Se o caracter de abertura n�o bater com o de fechamento, T� ERRADO PORRA
                    if (LOpenCloseCharacters[LBeforeChar] != LChar)
                        return false;
                }
            }

            if (!LStack.IsEmpty()) return false;

            return true;
        }

        /// <summary>
        /// Converte uma express�o infixa em p�sfixa
        /// </summary>
        /// <param name="expr">Express�o infixa a converter</param>
        /// <returns>A express�o p�sfixa</returns>
        public string Converter(string expr)
        {
            MyStack<char> LStack = new MyStack<char>(expr.Length);
            StringBuilder LPosFixa = new StringBuilder(expr.Length);

            expr = expr
                .Replace('{', '(')
                .Replace('[', '(')
                .Replace('}', ')')
                .Replace(']', ')');

            // Para cada caracter da minha express�o
            foreach (char LChar in expr)
            {
                if (IsOperand(LChar))
                {
                    LPosFixa.Append(LChar);
                }
                else if (IsOperator(LChar))
                {
                    int LPriority = Priority(LChar);

                    while (!LStack.IsEmpty() && Priority(LStack.Top()) >= LPriority)
                    {
                        LPosFixa.Append(LStack.Pop());
                    }

                    LStack.Push(LChar);
                }
                else if (LChar == '(')
                {
                    LStack.Push(LChar);
                }
                else
                {
                    if (LStack.IsEmpty()) continue;
                    char c = LStack.Pop();
                    while (c != '(' && !LStack.IsEmpty())
                    {
                        LPosFixa.Append(c);
                        c = LStack.Pop();
                    }
                }
            }

            while (!LStack.IsEmpty())
            {
                LPosFixa.Append(LStack.Pop());
            }

            return LPosFixa.ToString();
        }



        /// <summary>
        /// Calcula o valor de uma express�o p�sfixa
        /// </summary>
        /// <param name="posfixa"> A express�o p�sfixa</param>
        /// <returns> O resultado da conta</returns>
        public double Calcular(string posfixa, Variavel[] vars)
        {
            MyStack<double> LStack = new MyStack<double>(vars.Length * 4);

            foreach (char LChar in posfixa)
            {
                if (IsOperand(LChar))
                {
                    LStack.Push(vars.First(v => v.Nome == LChar.ToString()).Valor);
                }
                else
                {
                    double y = LStack.Pop();
                    double x = LStack.Pop();

                    switch (LChar)
                    {
                        case '+': LStack.Push(x + y); break;
                        case '-': LStack.Push(x - y); break;
                        case '*': LStack.Push(x * y); break;
                        case '/': LStack.Push(x / y); break;
                        case '^': LStack.Push(Math.Pow(x,y)); break;
                    }
                }
            }

            return LStack.Pop();
        }

    }


    /// <summary>
    /// Classe com os nomes e valores das vari�veis
    /// </summary>
    public class Variavel
    {
        private string nome;
        private double valor;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
