using System;

namespace _3__Soma_3_números
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número: ");
            double n1= Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Digite outro número: ");
            double n2= Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Digite mais um número: ");
            double n3= Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            System.Console.WriteLine($"A soma é: {soma(n1, n2, n3)}"); 
        }



        static double soma(double a, double b, double c) {
            double soma = a+b+c;

            return soma;
        }
    }
}
