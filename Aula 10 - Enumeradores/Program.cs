//Enumerador permitem criar um tipo personalizado, com possíveis valores pré-definidos pelo próprio programador.

using System;

namespace Aula_10___Enumeradores
{
    class Program
    {
        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}
        static void Main(string[] args)
        {
            DiasSemana ds = DiasSemana.Domingo;
            System.Console.WriteLine(ds + "\n");

            ds = (DiasSemana) 1; //Pega a posição 1. Você precisa converter.
            System.Console.WriteLine(ds + "\n");

            int DS = (int) DiasSemana.Terça; //Pega a posição do valor "Terça".
            System.Console.WriteLine(DS);     
        }
    }
}
