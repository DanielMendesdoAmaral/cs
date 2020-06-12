using System;

namespace Aula_18___Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] doisAOito= new int [2,2]; //O primeiro número é a quantidade de linhas e o segundo, colunas.
            doisAOito[0,0] = 2;
            doisAOito[0,1] = 4;
            doisAOito[1,0] = 6;
            doisAOito[1,1] = 8;
            System.Console.WriteLine("Matriz de dois à oito: \n{0} {1}\n{2} {3}\n", doisAOito[0,0], doisAOito[0,1], doisAOito[1,0], doisAOito[1,1]);

            int[,] JogoDaVelha = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}; //Cada {} é uma linha, cada elemento espaçado por vírgula é uma coluna.
            System.Console.WriteLine("{0} {1} {2} \n{3} {4} {5} \n{6} {7} {8}", JogoDaVelha[0,0], JogoDaVelha[0,1], JogoDaVelha[0,2], JogoDaVelha[1,0], JogoDaVelha[1,1], JogoDaVelha[1,2], JogoDaVelha[2,0], JogoDaVelha[2,1], JogoDaVelha[2,2]);

        }
    }
}
