using System;

namespace Aula_54___Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            OperaçoesMatematicas.OperacaoUm o = new OperaçoesMatematicas.OperacaoUm(8, 2); //Utilizamos outro namespace. Precisamos informar, ou usar um using. No caso, System é um namespace.
            Console.WriteLine( o.Soma() );
        }
    }
}

namespace OperaçoesMatematicas {
    public class OperacaoUm {
        double n1;
        double n2;

        public OperacaoUm(double a, double b) {
            n1=a;
            n2=b;
        }

        public double Soma() {
            return n1+n2;
        }
    }
}
