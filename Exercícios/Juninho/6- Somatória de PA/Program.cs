using System;

namespace _6__Somatória_de_PA
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, soma = 0;

            System.Console.Write("Insira a razão da PA: ");
            int razao = Int32.Parse(Console.ReadLine());
            System.Console.Write("Insira o último termo da PA: ");
            int ultimoTermo = Int32.Parse(Console.ReadLine());
            System.Console.Clear();

            for (contador=1; contador<=ultimoTermo; contador+=razao){
                soma += contador;
            }

            System.Console.WriteLine("A somatória da PA é: " + soma);
        }
    }
}
