using System;

namespace _1__Linhas_e_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do {
                System.Console.Write("Informe um número natural: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n<1); //Permite a entrada apenas de números naturais

            linhas(n); //Passa o parâmetro para a função
        }



        static void linhas (int n) { //Essa função faz todo o programa. Recebe como parametro o número máximo.
            for (int c=1; c<=n; c++) { //Enquanto o contador 1 for menor que o número máximo, ele vai repetir. Considere isso como cada linha.
                for (int c2=0; c2<c; c2++) { //O contador dois vai receber o número e vai escrever ele quantas vezes for necessário. Considere isso como os números.
                    System.Console.Write(" " + c); //Escreve com um espaço
                }
                System.Console.WriteLine(); //A cada linha ele vai para a linha de baixo.
            }
        }
    }
}
