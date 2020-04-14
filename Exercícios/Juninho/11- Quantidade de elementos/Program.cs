/* Crie um programa que tenha uma única função, além da principal, que receberá como parâmetro uma string não vazia s (com no máximo 50 caracteres de conteúdo) e exibirá a quantidade de caracteres de s. Observações: (a) apenas um laço de repetição; (b) sem matrizes auxiliares; (c) não usar funções prontas; (d) função iterativa.

Formato de entrada

A casa amarela

Formato de saida

14 */

using System;

namespace _11__Quantidade_de_elementos
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine(), a;
            string[] entradas = new string[50];
            int i = 1, qtd = 0;
            do {
                a = entrada.Substring(0, i);
                i++;
                qtd++;
            } while (a != entrada);
            System.Console.WriteLine(qtd);
        }
    }
}
