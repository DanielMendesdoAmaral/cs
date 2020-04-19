using System;

namespace _1__Analisador_de_textos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Seu nome em maiúsculas é {0}", nome.ToUpper());
            System.Console.WriteLine("Seu nome em minúsculas é {0}", nome.ToLower());
            string[] espaços = nome.Split(" ");
            int quantidadeEspacos = espaços.Length-1;
            System.Console.WriteLine("Seu nome tem {0} letras", nome.Length-quantidadeEspacos);
            System.Console.WriteLine("Seu primeiro nome é {0} e ele tem {1} letras", espaços[0], espaços[0].Length);
        }
    }
}
