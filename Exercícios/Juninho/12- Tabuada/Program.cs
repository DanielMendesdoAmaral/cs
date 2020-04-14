/*Faça um programa de resolução de tabuada. O programa deve inicialmente receber 2 números que indicam de quais números devem ser impressas a tabuada. Por exemplo, se forem recebidos os valores 2 e 5, seu programa deve Imprimir a tabuada de 2, 3, 4 e 5. O programa só deve aceitar valores entre 1 e 9. Enquanto o usuário digitar valores que não sejam esses, emita uma mensagem de erro.

Formato de entrada

Dois números em 2 linhas distintas indicando o intervalos dos números das tabuadas.

Formato de saía

As tabuadas dos números dentro do intervalo.

Entrada

Saida

2 x 1 = 2 2 x 2 = 4 2 x 3 = 6 2 x 4 = 8 2 x 5 = 10 2 x 6 = 12 2 x 7 = 14 2 x 8 = 16 2 x 9 = 18
Entrada

0

1

10

4

Insira um número inicial entre 1 e 9 Insira um número final entre 1 e 9 1 X 1 = 1 1 X 2 = 2 1 x 3 = 3 1 x 4 = 4 1 x 5 = 5 1 x 6 = 6 1 x 7 = 7 1 x 8 = 8 1 x 9 = 9
Entrada 

8

7

Saída

Nenhuma tabuada nesse intervalo */

using System;

namespace _12__Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0, fim = 0;

            do {
                inicio = Int32.Parse(Console.ReadLine());
                if ((inicio<=0) || (inicio>=10)) {
                    System.Console.WriteLine("Insira um valor inicial entre 1 e 9.");
                }
            } while ((inicio<=0) || (inicio>=10));

            do {
                fim = Int32.Parse(Console.ReadLine());
                if ((fim<=0) || (fim>=10)){
                    System.Console.WriteLine("Insira um valor final entre 1 e 9.");
                }
            } while ((fim<=0) || (fim>=10));

            if (fim < inicio) {
                System.Console.WriteLine("Nenhuma tabuada nesse intervalo!");
            }
            else {
                for (int contador = inicio; contador <= fim; contador++) {
                    for (int multi = 0; multi <= 10; multi++) {
                        int produto = contador*multi;
                        System.Console.WriteLine(contador + " X " + multi + " = " + produto);
                    }
                    System.Console.WriteLine();
                }
            }
        }
    }
}
