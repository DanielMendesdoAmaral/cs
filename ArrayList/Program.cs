using System;
using System.Collections; //Precisa disto para as listas funcionarem.

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);

            foreach (int n in numeros) {
                System.Console.Write("{0} ", n);
            }
        }
    }
}
