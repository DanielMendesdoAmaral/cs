using System;

namespace Aula_9___Operadores_de_bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funciona apenas com números inteiros
            //>> Desloca um bit para a direita, resultando na metade do número
            //<< Desloca um bit para a esquerda, resultando no dobro do número
            //Por exemplo, o número 4 = 00000100. Ao ser deslocado 1 bit para a direita, ele é reduzido pela metade, totalizando 2 = 00000010
            //O número 4 = 00000100 ao ser deslocado 1 bit para a esquerda, é dobrado, totalizando 8 = 00001000

            int quatro = 4;
            System.Console.WriteLine(quatro>>1); //Desloca 1 bit
            System.Console.WriteLine(quatro<<1); 

            System.Console.WriteLine("");

            System.Console.WriteLine(quatro>>2); //Desloca 2 bits, divive por 4 (>> )ou quadriplica (<<). Pense assim: Você dobra 2 vezes, ou, divide pela metade duas vezes.
            System.Console.WriteLine(quatro<<2);
        }
    }
}
