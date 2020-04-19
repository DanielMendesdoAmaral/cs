using System;

namespace Aula_16___GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio: //Ponto do programa indicado no GoTo. Serve para voltar para determinado ponto do programa. Óbviamente não precisa ser no início, nem ter esse nome.

            Console.Clear();

            System.Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            
            System.Console.WriteLine("Quer digitar as informações novamente? [s/n]");
            string opcao = Console.ReadLine();

            if (opcao=="s") {
                goto inicio;
            }

        }
    }
}