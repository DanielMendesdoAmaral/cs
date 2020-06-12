using System;

namespace Aula_25___Passagem_por_valor_e_por_referência
{
    class Program
    {
        static void Main(string[] args)
        {
            //Por valor
            int quatro = 4;
            dobrar(quatro); //Para utilizar o novo valor, você precisará printá-lo ou armazená-lo em uma variável.
            System.Console.WriteLine(quatro); //Como não printamos a função diretamente, ou não armazenamos numa variável, ele printará o valor original, que é 4, e não o valor dobrado.


            //Por referência
            int dez = 10;
            metade(ref dez);
            System.Console.WriteLine(dez); //Aqui não precisamos armazenar, pois a variável TEM o novo valor.
        }

        static void dobrar(int d) { //Por valor
            d *= 2;
        }

        static void metade(ref int m) { //Por referência
            m /= 2;
        }
    }
}
