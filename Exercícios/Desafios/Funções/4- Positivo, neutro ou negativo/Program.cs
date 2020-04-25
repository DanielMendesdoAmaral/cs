/* Faça um programa, com uma função que necessite de um argumento. A função retorna o valor de caractere ‘P’, se seu argumento for positivo, e ‘N’, se seu argumento for zero ou negativo. */

using System;

namespace _4__Positivo__neutro_ou_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número real: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            System.Console.WriteLine(pnn(n));
        }



        static string pnn(double n) {
            if (n>0) {
                return "P";
            }
            else {
                return "N";
            }
        }
    }
}
