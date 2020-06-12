using System;

namespace Aula_51___Argumentos_de_entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            //O parâmetro de entrada args é inserido junto com a inicialização do programa, ou seja: dotnet run a b c d qualquer parametro.

            for (int c=0; c<args.Length; c++) {
                System.Console.WriteLine(args[c]);
            }
        }
    }
}
