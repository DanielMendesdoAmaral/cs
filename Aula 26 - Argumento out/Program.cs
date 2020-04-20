using System;

namespace Aula_26___Argumento_out
{
    class Program
    {
        //O argumento out serve para retornar mais de um valor.
        static void Main(string[] args)
        {
            int a=10, b=3, c=0, d=divisao(a, b, out c);
            
            System.Console.WriteLine("{0}/{1} = {2}, sobrando {3}.", a, b, d, c);

            //Note que out parece bastante com o ref, pois você não precisou guardar o resto numa variável, apenas os outros valores.
        }

        static int divisao(int dividendo, int divisor, out int resto) {
            int quociente = dividendo/divisor;
            resto = dividendo%divisor;
            return quociente;
        }

    }
}
