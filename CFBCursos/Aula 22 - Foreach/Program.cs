using System;

namespace Aula_22___Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] jogoDaVelha = new int [3,3];
            int nove = 1;
            
            for (int l=0; l<=2; l++) {
                for (int c=0; c<=2; c++) {
                    jogoDaVelha[l,c] = nove++;
                }
            }

            foreach (int linha in jogoDaVelha) { //Dava para fazer tudo lá no for, mas é só uma demonstração
                System.Console.Write(linha + " ");
                if (linha%3==0) {
                    System.Console.WriteLine();
                }
            }
        }
    }
}
