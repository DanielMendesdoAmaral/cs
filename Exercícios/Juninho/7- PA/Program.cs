using System;

namespace _7__PA
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o número de termos: ");
            int numeroTermos = Int32.Parse(Console.ReadLine());

            double soma = 0;

            for (int contador = 1; contador <= numeroTermos; contador++) {
                double divisao = (double) 1/contador;
                if (contador%2==0) {
                    soma = (double) soma + divisao;
                }
                else {
                    soma = (double) soma - divisao;
                }
            }
            System.Console.WriteLine("A somatória da PA é: " + (Math.Round(soma, 6)));
        }
    }
}
