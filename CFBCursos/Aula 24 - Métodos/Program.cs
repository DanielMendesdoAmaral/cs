using System;

namespace Aula_24___Métodos
{
    class Program
    {
        static void Main(string[] args) { //Este é um método principal. Como ele é static, ele só consegue chamar outros métodos se estes forem statics também. 
            ola();

            soma(5, 5);

            int produto = multiplicacao(5, 5);
            System.Console.WriteLine(produto);
        }

        static void ola() { //Um método void não pode retornar dados.
            System.Console.WriteLine("Olá mundo em métodos!\n");
        }

        static void soma(int x, int y) {
            int soma = x+y;
            System.Console.WriteLine("A soma entre {0} e {1} é {2}", x, y, soma);
        }

        static int multiplicacao(int a, int b) { //Agora esta função não tem mais um reotrno void. Ela tem um retorno de um número inteiro.
            int multiplicacao = a*b;
            return multiplicacao;
        }

    }
}
