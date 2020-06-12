using System;

namespace Aula_32___This
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos soma = new Calculos(10, 5); //Exemplos um pouco redundantes. 
            System.Console.WriteLine(soma.Somar(10, 5));
        }
    }

    public class Calculos {
        int v1, v2; //Esses são os valores do this. 
        public Calculos(int v1, int v2) {
            this.v1=v1; //Use o this para não confundir o C#. Se não ele vai dar erro de atribuição à mesma variável. 
            this.v2=v2;
        }
        public int Somar(int v1, int v2) {
            return v1+v2;
        }
    }
}
