using System;

namespace _2__Separando_dígitos_de_um_número
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Informe um número: ");
            string numero = Console.ReadLine();
            System.Console.WriteLine("Analisando o número {0}...", numero);
            string novoNumero = "1234";
            novoNumero = novoNumero.Replace("4", numero); //Replace troca um pelo outro
            novoNumero = novoNumero.Replace("123", "000");
            System.Console.WriteLine("Unidade: {0}", novoNumero.Substring(novoNumero.Length-1,1)); //Length verifica o tamanho. Pode verificar o número de caracteres de uma string ou o número de índices de um array.
            System.Console.WriteLine("Dezena: {0}", novoNumero.Substring(novoNumero.Length-2,1));
            System.Console.WriteLine("Centena: {0}", novoNumero.Substring(novoNumero.Length-3,1));
            System.Console.WriteLine("Milhar: {0}", novoNumero.Substring(novoNumero.Length-4,1));
        }
    }
}
