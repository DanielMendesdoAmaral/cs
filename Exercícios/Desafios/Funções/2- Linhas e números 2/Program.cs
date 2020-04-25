using System;

namespace _2__Linhas_e_números_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            do {
                System.Console.Write("Informe um número natural: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n<1);

            numeros(n);
        }



        static void numeros(int n) {
            for (int c=1; c<=n; c++) {
                for (int c2=1; c2<=c; c2++) {
                    System.Console.Write(" " + c2);
                }
                System.Console.WriteLine();
            }
        }
    }
}
