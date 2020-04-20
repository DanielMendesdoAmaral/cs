using System;

namespace Aula_27___Argumento_params
{
    class Program
    {
        //O argumento params serve para quando não tem um número de parametros definidos. Pode ser 0, 1, 5, 140, 100000, etc.

        static void Main(string[] args)
        {
            somar();
            somar(10);
            somar(10, 10, 10, 10, 10);
        }

        static void somar(params int[]n) { //Precisa ser void.
            int resultado = 0;

            if (n.Length==0) {
                resultado = 0;
            }
            else if (n.Length==1) {
                resultado = n[0];
            }
            else {
                for (int c=0; c<n.Length; c++) {
                    resultado += n[c];
                }
            }

            System.Console.WriteLine("O resultado da soma é {0}", resultado);
        }

    }
}
