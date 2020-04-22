using System;

namespace Aula_6___Formatando_a_saída_do_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            n1=10; n2=20; n3=30;
            System.Console.WriteLine("O valor de n1 é {0}, \to valor de n2 é {1} e \to valor de n3 é {2}.", n1, n2, n3); //\t insere um espaço
            System.Console.WriteLine("\n \n \n"); //Pula linha

            double valorCompra = 5.50, lucro = 0.1, valorVenda = valorCompra + (valorCompra * lucro);
            string produto = "Pastel";
            System.Console.WriteLine("Produto......:{0,15}", produto); //Coloca produto na posição 0, após dar 15 espaços.
            System.Console.WriteLine("Val.Compra...:{0,15:c}", valorCompra); //Cach, formata como valor
            System.Console.WriteLine("Lucro........:{0,15:p}", lucro); //Porcentagem, formata como porcentagem
            System.Console.WriteLine("Val.Venda....:{0,15:c}", valorVenda);

            int b = 3;

            System.Console.WriteLine($"Teste {b}");
        }
    }
}
