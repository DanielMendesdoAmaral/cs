using System;

namespace _5__Múltiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,x,multiplo = 0;
            do {
                System.Console.Write("Digite um número: ");
                x = Int32.Parse(Console.ReadLine());
                if (x<1) {
                    System.Console.WriteLine("ERRO! O NÚMERO DEVE SER MAIOR QUE 0.");
                }
                System.Threading.Thread.Sleep(1000);
                System.Console.Clear();
            } while (x<1);
            do {
                System.Console.Write("Digite outro número: ");
                n = Int32.Parse(Console.ReadLine());
                if (n<x) {
                    System.Console.WriteLine("ERRO! O NÚMERO DEVE SER MAIOR QUE O NÚMERO ANTERIOR (" + x + ").");
                }
                System.Threading.Thread.Sleep(1000);
                System.Console.Clear();
            } while (n<x);
            for (int contador = x; contador<n; contador++) {
                if (contador%x==0){
                    multiplo = multiplo + 1;
                }
            }
            System.Console.WriteLine("O número " + x + " tem " + multiplo + " múltiplos menores que " + n + ".");
        }
    }
}
