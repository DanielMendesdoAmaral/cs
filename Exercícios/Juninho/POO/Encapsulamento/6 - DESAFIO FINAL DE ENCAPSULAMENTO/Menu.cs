using System;
using System.Collections.Generic;
using System.Text;

namespace _6___DESAFIO_FINAL_DE_ENCAPSULAMENTO
{
    class Menu
    {
        private string[] opcoes = new string[1000]; //Vetor de 1000 posições, que guarda cada opção.

        public Menu(params string[] o) //Construtor que recebe as opções determinadas pelo usuário (a quantidade de opções também será determinada por ele).
        {
            for (int c = 0; c < o.Length; c++) //Todas as opções digitadas no construtor serão adicionadas no vetor "opcoes".
            {
                opcoes[c] = o[c];
            }
        }

        public string[] GetOpcoes()
        {
            return opcoes;
        }

        public void SetOpcoes(int i, string[] v, string o)
        {
            v[i] = o;
        }

        public void MostrarOpcoes()
        {
            if (opcoes[0] == null) //Se não houver opções no vetor, ele não fará nada. Caso o contrário, ele construirá o menu.
            {
                opcoes = null;
            }
            else
            {
                System.Console.WriteLine("\n");
                for (int c = 0; c < opcoes.Length; c++)
                {
                    if (opcoes[c] == null)
                    {
                        break;
                    }
                    else //Se na posição c do vetor "opcoes" tiver alguma opção, ela será mostrada no console. Caso o contrário, sairá pelo break.
                    {
                        int esgotou;
                        System.Console.Write("    [");
                        System.Console.ForegroundColor = System.ConsoleColor.DarkYellow;
                        System.Console.Write(c + 1);
                        System.Console.ForegroundColor = System.ConsoleColor.White;
                        System.Console.Write($"] {opcoes[c]}");
                        System.Console.WriteLine();
                        if (opcoes[c + 1] == null) //Se já tiver acabado as opçoes
                        {
                            System.Console.WriteLine();
                            System.Console.Write("    ENTRADA: ");
                        }
                    }
                }
            }
        }

        public void CriarBarraLoad()
        {
            string barraVerde = "██";
            for (int c = 0; c <= 100; c++)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.Write(barraVerde);
                barraVerde += "██";
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.ForegroundColor = System.ConsoleColor.White;
                System.Console.Write($"                                                                                                Loading...     {c}%");
                System.Threading.Thread.Sleep(25);
                System.Console.Clear();
            }
        }
    }
}