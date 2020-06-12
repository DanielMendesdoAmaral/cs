using System;

namespace Aula_37___Ordem_de_execução_de_construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            FilhaFilha ff = new FilhaFilha(); //Ao instanciar um objeto filho do filho da base, ele executará os construtores na seguinte ordem: base, filhadabase, filhadafilhadabase. Sempre será assim, de pai para filhos.
        }
    }

    class Base {
        public Base() {
            System.Console.WriteLine("BASE");
        } 
    }

    class FilhaBase : Base {
        public FilhaBase() {
            System.Console.WriteLine("FILHA DA BASE");
        }
    }

    class FilhaFilha : FilhaBase {
        public FilhaFilha() {
            System.Console.WriteLine("FILHA DA FILHA");
        }
    }
}
