/* Crie um programa que tenha uma única função, além da principal, que receberá como parâmetros um natural n (0<=n<=2^30) e um digito x (0<=X<=9) e devolverá a quantidade de ocorrências de x em n.O programa exibirá o retorno da função. Observações: (a) apenas um laço de repetição; (b) sem matrizes; (c) função iterativa.

Formato de entrada

142434530 4

Formato de saída

3 */

using System;

namespace _10__Localizar_elemento
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            string[] strings = new string[2];
            strings = entrada.Split(" ");
            string[] entradas = new string[10];
            int qtd = 0;

            for (int contador = 0; contador <= 8; contador++) {
                entradas[contador] = strings[0].Substring(contador, 1);
                if (entradas[contador]==strings[1]) {
                    qtd++;
                }
            }

            System.Console.WriteLine(qtd);
        }
    }
}
