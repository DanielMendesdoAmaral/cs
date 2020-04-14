using System;

namespace _2__Loja_de_tintas
{
    class Program
    {
        static void Main(string[] args)
        {
            double peq = 5.4, gnd = 24, preco = 0, peqc = 5.4, gndc = 24;

            Console.Write("Quantos metros quadrados você irá pintar? ");
            double metros = Double.Parse(Console.ReadLine());
            Console.Clear();

            double qtd = (double)metros/7;

            System.Console.WriteLine("Você pode comprar: \n");

            gnd = Math.Ceiling(qtd/gnd);
            preco = gnd*91;
            Console.WriteLine("a) " + gnd + " lata(s) de 24 litros: " + preco.ToString("C"));

            peq = Math.Ceiling(qtd/peq);
            preco = peq*23;
            Console.WriteLine("b) " + peq + " lata(s) de 5.4 litros: " + preco.ToString("C"));

            gndc = Math.Floor(qtd/gndc);
            peqc = Math.Ceiling((qtd-(gndc*24))/5.4);
            preco = gndc*91 + peqc*23;
            Console.WriteLine("c) " + gndc + " lata(s) de 24 litros e " + peqc + " lata(s) de 5.4 litros: " + preco.ToString("C"));
        }
    }
}
